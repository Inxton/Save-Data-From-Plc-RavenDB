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
	public partial interface IDataManager : Vortex.Connector.IVortexOnlineObject, TcoData.ITcoDataExchange
	{
		IData _data
		{
			get;
		}

		new Plc.PlainDataManager CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainDataManager source);
		void FlushOnlineToPlain(Plc.PlainDataManager source);
	}
}