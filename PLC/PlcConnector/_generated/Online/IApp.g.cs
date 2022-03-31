using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IApp : Vortex.Connector.IVortexOnlineObject, TcoCore.ITcoContext
	{
		Vortex.Connector.ValueTypes.Online.IOnlineInt Step
		{
			get;
		}

		TcoCore.ITcoRemoteTask GenerateDataTask
		{
			get;
		}

		IDataManager DataManager
		{
			get;
		}

		new Plc.PlainApp CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainApp source);
		void FlushOnlineToPlain(Plc.PlainApp source);
	}
}