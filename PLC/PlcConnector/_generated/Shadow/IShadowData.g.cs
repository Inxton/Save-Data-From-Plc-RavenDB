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
	public partial interface IShadowData : Vortex.Connector.IVortexShadowObject, TcoData.IShadowTcoEntity
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString DataId
		{
			get;
		}

		IShadowPerson Person_0
		{
			get;
		}

		IShadowPerson Person_1
		{
			get;
		}

		IShadowPerson Person_2
		{
			get;
		}

		IShadowPerson Person_3
		{
			get;
		}

		IShadowPerson Person_4
		{
			get;
		}

		IShadowPerson Person_5
		{
			get;
		}

		IShadowPerson Person_6
		{
			get;
		}

		IShadowPerson Person_7
		{
			get;
		}

		IShadowPerson Person_8
		{
			get;
		}

		IShadowPerson Person_9
		{
			get;
		}

		new Plc.PlainData CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainData source);
	}
}