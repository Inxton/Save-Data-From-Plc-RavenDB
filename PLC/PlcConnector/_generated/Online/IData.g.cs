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
	public partial interface IData : Vortex.Connector.IVortexOnlineObject, TcoData.ITcoEntity
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString DataId
		{
			get;
		}

		IPerson Person_0
		{
			get;
		}

		IPerson Person_1
		{
			get;
		}

		IPerson Person_2
		{
			get;
		}

		IPerson Person_3
		{
			get;
		}

		IPerson Person_4
		{
			get;
		}

		IPerson Person_5
		{
			get;
		}

		IPerson Person_6
		{
			get;
		}

		IPerson Person_7
		{
			get;
		}

		IPerson Person_8
		{
			get;
		}

		IPerson Person_9
		{
			get;
		}

		new Plc.PlainData CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainData source);
		void FlushOnlineToPlain(Plc.PlainData source);
	}
}