using Plc;
using System.Windows;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace Invoke_Csharp_From_PLC
{
    public partial class MainWindow : Window
    {
        private static readonly string AmsId = "172.20.10.2.1.1";
        public PlcTwinController Plc { get; set; } = new PlcTwinController(Tc3ConnectorAdapter.Create(AmsId, 851));

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Plc.Connector.BuildAndStart();
            Plc.MAIN.App.Invoke_C_Sharp.Initialize(CallThisMethod);
        }

        private void CallThisMethod()
        {
            Plc.MAIN.App.Increment.Cyclic = Plc.MAIN.App.Increment.Cyclic * 2 ;
        }
    }
}
