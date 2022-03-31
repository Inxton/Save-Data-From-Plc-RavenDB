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
	public partial interface IPerson : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString FirstName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString LastName
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Age
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate Birthday
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString BirthTown
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainPerson CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainPerson source);
		void FlushOnlineToPlain(Plc.PlainPerson source);
	}
}