using Bogus;
using Plc;
using TcOpen.Inxton.Data;
using TcOpen.Inxton.RavenDb;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace Save_Data_From_Plc
{
    class Program
    {
        static MAIN MAIN { get; set; }
        static void Main(string[] args)
        {
            var plc = new PlcTwinController(Tc3ConnectorAdapter.Create("192.168.4.1.1.1", 851));
            plc.Connector.BuildAndStart();
            MAIN = plc.MAIN;
            plc.MAIN.App.GenerateDataTask.Initialize(GenerateData);
            var repository = CreateRepository();
            plc.MAIN.App.DataManager.InitializeRepository(repository);
            plc.MAIN.App.DataManager.InitializeRemoteDataExchange(repository);
            System.Console.ReadKey();
        }

        private static IRepository<PlainData> CreateRepository()
        {
            var connectionString = new string[] { @"http://localhost:8080" };
            var dbName = "InxtonData";
            string cert = "", certPass = "";
            var ravendb = new RavenDbRepository<PlainData>(new RavenDbRepositorySettings<PlainData>(connectionString, dbName, cert, certPass));
            return ravendb;
        }

        private static bool GenerateData()
        {
            var personFaker = new Faker<PlainPerson>()
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.Age, f => (short)f.Random.Number(18, 60))
                .RuleFor(o => o.Birthday, (f, o) => f.Date.Past(o.Age))
                .RuleFor(o => o.BirthTown, (f, o) => f.Address.City());

            var dataFaker = new Faker<PlainData>()
                .RuleFor(o => o.DataId, f => f.Database.Random.Guid().ToString())
                .RuleForType(typeof(PlainPerson), f => personFaker.Generate());

            var newData = dataFaker.Generate();

            MAIN.App.DataManager._data.FlushPlainToOnline(newData);

            return true;
        }
    }
}
