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
	public partial interface IShadowApp : Vortex.Connector.IVortexShadowObject, TcoCore.IShadowTcoContext
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowInt Step
		{
			get;
		}

		TcoCore.IShadowTcoRemoteTask GenerateDataTask
		{
			get;
		}

		IShadowDataManager DataManager
		{
			get;
		}

		new Plc.PlainApp CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainApp source);
	}
}