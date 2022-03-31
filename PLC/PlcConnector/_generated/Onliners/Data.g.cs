using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "Data", "Plc", TypeComplexityEnum.Complex)]
	public partial class Data : TcoData.TcoEntity, Vortex.Connector.IVortexObject, IData, IShadowData, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerString _DataId;
		public Vortex.Connector.ValueTypes.OnlinerString DataId
		{
			get
			{
				return _DataId;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IData.DataId
		{
			get
			{
				return DataId;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowData.DataId
		{
			get
			{
				return DataId;
			}
		}

		Person _Person_0;
		public Person Person_0
		{
			get
			{
				return _Person_0;
			}
		}

		IPerson IData.Person_0
		{
			get
			{
				return Person_0;
			}
		}

		IShadowPerson IShadowData.Person_0
		{
			get
			{
				return Person_0;
			}
		}

		Person _Person_1;
		public Person Person_1
		{
			get
			{
				return _Person_1;
			}
		}

		IPerson IData.Person_1
		{
			get
			{
				return Person_1;
			}
		}

		IShadowPerson IShadowData.Person_1
		{
			get
			{
				return Person_1;
			}
		}

		Person _Person_2;
		public Person Person_2
		{
			get
			{
				return _Person_2;
			}
		}

		IPerson IData.Person_2
		{
			get
			{
				return Person_2;
			}
		}

		IShadowPerson IShadowData.Person_2
		{
			get
			{
				return Person_2;
			}
		}

		Person _Person_3;
		public Person Person_3
		{
			get
			{
				return _Person_3;
			}
		}

		IPerson IData.Person_3
		{
			get
			{
				return Person_3;
			}
		}

		IShadowPerson IShadowData.Person_3
		{
			get
			{
				return Person_3;
			}
		}

		Person _Person_4;
		public Person Person_4
		{
			get
			{
				return _Person_4;
			}
		}

		IPerson IData.Person_4
		{
			get
			{
				return Person_4;
			}
		}

		IShadowPerson IShadowData.Person_4
		{
			get
			{
				return Person_4;
			}
		}

		Person _Person_5;
		public Person Person_5
		{
			get
			{
				return _Person_5;
			}
		}

		IPerson IData.Person_5
		{
			get
			{
				return Person_5;
			}
		}

		IShadowPerson IShadowData.Person_5
		{
			get
			{
				return Person_5;
			}
		}

		Person _Person_6;
		public Person Person_6
		{
			get
			{
				return _Person_6;
			}
		}

		IPerson IData.Person_6
		{
			get
			{
				return Person_6;
			}
		}

		IShadowPerson IShadowData.Person_6
		{
			get
			{
				return Person_6;
			}
		}

		Person _Person_7;
		public Person Person_7
		{
			get
			{
				return _Person_7;
			}
		}

		IPerson IData.Person_7
		{
			get
			{
				return Person_7;
			}
		}

		IShadowPerson IShadowData.Person_7
		{
			get
			{
				return Person_7;
			}
		}

		Person _Person_8;
		public Person Person_8
		{
			get
			{
				return _Person_8;
			}
		}

		IPerson IData.Person_8
		{
			get
			{
				return Person_8;
			}
		}

		IShadowPerson IShadowData.Person_8
		{
			get
			{
				return Person_8;
			}
		}

		Person _Person_9;
		public Person Person_9
		{
			get
			{
				return _Person_9;
			}
		}

		IPerson IData.Person_9
		{
			get
			{
				return Person_9;
			}
		}

		IShadowPerson IShadowData.Person_9
		{
			get
			{
				return Person_9;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			DataId.Shadow = DataId.LastValue;
			Person_0.LazyOnlineToShadow();
			Person_1.LazyOnlineToShadow();
			Person_2.LazyOnlineToShadow();
			Person_3.LazyOnlineToShadow();
			Person_4.LazyOnlineToShadow();
			Person_5.LazyOnlineToShadow();
			Person_6.LazyOnlineToShadow();
			Person_7.LazyOnlineToShadow();
			Person_8.LazyOnlineToShadow();
			Person_9.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			DataId.Cyclic = DataId.Shadow;
			Person_0.LazyShadowToOnline();
			Person_1.LazyShadowToOnline();
			Person_2.LazyShadowToOnline();
			Person_3.LazyShadowToOnline();
			Person_4.LazyShadowToOnline();
			Person_5.LazyShadowToOnline();
			Person_6.LazyShadowToOnline();
			Person_7.LazyShadowToOnline();
			Person_8.LazyShadowToOnline();
			Person_9.LazyShadowToOnline();
		}

		public new PlainData CreatePlainerType()
		{
			var cloned = new PlainData();
			base.CreatePlainerType(cloned);
			cloned.Person_0 = Person_0.CreatePlainerType();
			cloned.Person_1 = Person_1.CreatePlainerType();
			cloned.Person_2 = Person_2.CreatePlainerType();
			cloned.Person_3 = Person_3.CreatePlainerType();
			cloned.Person_4 = Person_4.CreatePlainerType();
			cloned.Person_5 = Person_5.CreatePlainerType();
			cloned.Person_6 = Person_6.CreatePlainerType();
			cloned.Person_7 = Person_7.CreatePlainerType();
			cloned.Person_8 = Person_8.CreatePlainerType();
			cloned.Person_9 = Person_9.CreatePlainerType();
			return cloned;
		}

		protected PlainData CreatePlainerType(PlainData cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Person_0 = Person_0.CreatePlainerType();
			cloned.Person_1 = Person_1.CreatePlainerType();
			cloned.Person_2 = Person_2.CreatePlainerType();
			cloned.Person_3 = Person_3.CreatePlainerType();
			cloned.Person_4 = Person_4.CreatePlainerType();
			cloned.Person_5 = Person_5.CreatePlainerType();
			cloned.Person_6 = Person_6.CreatePlainerType();
			cloned.Person_7 = Person_7.CreatePlainerType();
			cloned.Person_8 = Person_8.CreatePlainerType();
			cloned.Person_9 = Person_9.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc.PlainData source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainData source)
		{
			source.CopyPlainToShadow(this);
		}

		public new void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public new void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainData source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Data(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_DataId = @Connector.Online.Adapter.CreateSTRING(this, "", "DataId");
			_Person_0 = new Person(this, "", "Person_0");
			_Person_1 = new Person(this, "", "Person_1");
			_Person_2 = new Person(this, "", "Person_2");
			_Person_3 = new Person(this, "", "Person_3");
			_Person_4 = new Person(this, "", "Person_4");
			_Person_5 = new Person(this, "", "Person_5");
			_Person_6 = new Person(this, "", "Person_6");
			_Person_7 = new Person(this, "", "Person_7");
			_Person_8 = new Person(this, "", "Person_8");
			_Person_9 = new Person(this, "", "Person_9");
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Data(): base ()
		{
			PexPreConstructorParameterless();
			_DataId = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Person_0 = new Person();
			_Person_1 = new Person();
			_Person_2 = new Person();
			_Person_3 = new Person();
			_Person_4 = new Person();
			_Person_5 = new Person();
			_Person_6 = new Person();
			_Person_7 = new Person();
			_Person_8 = new Person();
			_Person_9 = new Person();
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainData
	{
		public void CopyPlainToCyclic(Plc.Data target)
		{
			base.CopyPlainToCyclic(target);
			target.DataId.Cyclic = DataId;
			Person_0.CopyPlainToCyclic(target.Person_0);
			Person_1.CopyPlainToCyclic(target.Person_1);
			Person_2.CopyPlainToCyclic(target.Person_2);
			Person_3.CopyPlainToCyclic(target.Person_3);
			Person_4.CopyPlainToCyclic(target.Person_4);
			Person_5.CopyPlainToCyclic(target.Person_5);
			Person_6.CopyPlainToCyclic(target.Person_6);
			Person_7.CopyPlainToCyclic(target.Person_7);
			Person_8.CopyPlainToCyclic(target.Person_8);
			Person_9.CopyPlainToCyclic(target.Person_9);
		}

		public void CopyPlainToCyclic(Plc.IData target)
		{
			this.CopyPlainToCyclic((Plc.Data)target);
		}

		public void CopyPlainToShadow(Plc.Data target)
		{
			base.CopyPlainToShadow(target);
			target.DataId.Shadow = DataId;
			Person_0.CopyPlainToShadow(target.Person_0);
			Person_1.CopyPlainToShadow(target.Person_1);
			Person_2.CopyPlainToShadow(target.Person_2);
			Person_3.CopyPlainToShadow(target.Person_3);
			Person_4.CopyPlainToShadow(target.Person_4);
			Person_5.CopyPlainToShadow(target.Person_5);
			Person_6.CopyPlainToShadow(target.Person_6);
			Person_7.CopyPlainToShadow(target.Person_7);
			Person_8.CopyPlainToShadow(target.Person_8);
			Person_9.CopyPlainToShadow(target.Person_9);
		}

		public void CopyPlainToShadow(Plc.IShadowData target)
		{
			this.CopyPlainToShadow((Plc.Data)target);
		}

		public void CopyCyclicToPlain(Plc.Data source)
		{
			base.CopyCyclicToPlain(source);
			DataId = source.DataId.LastValue;
			Person_0.CopyCyclicToPlain(source.Person_0);
			Person_1.CopyCyclicToPlain(source.Person_1);
			Person_2.CopyCyclicToPlain(source.Person_2);
			Person_3.CopyCyclicToPlain(source.Person_3);
			Person_4.CopyCyclicToPlain(source.Person_4);
			Person_5.CopyCyclicToPlain(source.Person_5);
			Person_6.CopyCyclicToPlain(source.Person_6);
			Person_7.CopyCyclicToPlain(source.Person_7);
			Person_8.CopyCyclicToPlain(source.Person_8);
			Person_9.CopyCyclicToPlain(source.Person_9);
		}

		public void CopyCyclicToPlain(Plc.IData source)
		{
			this.CopyCyclicToPlain((Plc.Data)source);
		}

		public void CopyShadowToPlain(Plc.Data source)
		{
			base.CopyShadowToPlain(source);
			DataId = source.DataId.Shadow;
			Person_0.CopyShadowToPlain(source.Person_0);
			Person_1.CopyShadowToPlain(source.Person_1);
			Person_2.CopyShadowToPlain(source.Person_2);
			Person_3.CopyShadowToPlain(source.Person_3);
			Person_4.CopyShadowToPlain(source.Person_4);
			Person_5.CopyShadowToPlain(source.Person_5);
			Person_6.CopyShadowToPlain(source.Person_6);
			Person_7.CopyShadowToPlain(source.Person_7);
			Person_8.CopyShadowToPlain(source.Person_8);
			Person_9.CopyShadowToPlain(source.Person_9);
		}

		public void CopyShadowToPlain(Plc.IShadowData source)
		{
			this.CopyShadowToPlain((Plc.Data)source);
		}
	}
}