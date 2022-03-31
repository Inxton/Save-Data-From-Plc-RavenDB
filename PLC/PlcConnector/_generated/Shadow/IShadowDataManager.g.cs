using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowDataManager : Vortex.Connector.IVortexShadowObject, TcoData.IShadowTcoDataExchange
	{
		IShadowData _data
		{
			get;
		}

		new Plc.PlainDataManager CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainDataManager source);
	}
}