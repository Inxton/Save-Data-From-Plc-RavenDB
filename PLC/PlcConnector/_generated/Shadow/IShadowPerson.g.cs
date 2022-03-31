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
	public partial interface IShadowPerson : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString FirstName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString LastName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Age
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate Birthday
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString BirthTown
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainPerson CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainPerson source);
	}
}