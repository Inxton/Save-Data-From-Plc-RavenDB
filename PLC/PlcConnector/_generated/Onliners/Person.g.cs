using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "Person", "Plc", TypeComplexityEnum.Complex)]
	public partial class Person : Vortex.Connector.IVortexObject, IPerson, IShadowPerson, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerString _FirstName;
		public Vortex.Connector.ValueTypes.OnlinerString FirstName
		{
			get
			{
				return _FirstName;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IPerson.FirstName
		{
			get
			{
				return FirstName;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowPerson.FirstName
		{
			get
			{
				return FirstName;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _LastName;
		public Vortex.Connector.ValueTypes.OnlinerString LastName
		{
			get
			{
				return _LastName;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IPerson.LastName
		{
			get
			{
				return LastName;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowPerson.LastName
		{
			get
			{
				return LastName;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Age;
		public Vortex.Connector.ValueTypes.OnlinerInt Age
		{
			get
			{
				return _Age;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IPerson.Age
		{
			get
			{
				return Age;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowPerson.Age
		{
			get
			{
				return Age;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDate _Birthday;
		public Vortex.Connector.ValueTypes.OnlinerDate Birthday
		{
			get
			{
				return _Birthday;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate IPerson.Birthday
		{
			get
			{
				return Birthday;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate IShadowPerson.Birthday
		{
			get
			{
				return Birthday;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _BirthTown;
		public Vortex.Connector.ValueTypes.OnlinerString BirthTown
		{
			get
			{
				return _BirthTown;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IPerson.BirthTown
		{
			get
			{
				return BirthTown;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowPerson.BirthTown
		{
			get
			{
				return BirthTown;
			}
		}

		public void LazyOnlineToShadow()
		{
			FirstName.Shadow = FirstName.LastValue;
			LastName.Shadow = LastName.LastValue;
			Age.Shadow = Age.LastValue;
			Birthday.Shadow = Birthday.LastValue;
			BirthTown.Shadow = BirthTown.LastValue;
		}

		public void LazyShadowToOnline()
		{
			FirstName.Cyclic = FirstName.Shadow;
			LastName.Cyclic = LastName.Shadow;
			Age.Cyclic = Age.Shadow;
			Birthday.Cyclic = Birthday.Shadow;
			BirthTown.Cyclic = BirthTown.Shadow;
		}

		public PlainPerson CreatePlainerType()
		{
			var cloned = new PlainPerson();
			return cloned;
		}

		protected PlainPerson CreatePlainerType(PlainPerson cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainPerson source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainPerson source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainPerson source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName, this).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public Person(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_FirstName = @Connector.Online.Adapter.CreateSTRING(this, "", "FirstName");
			_LastName = @Connector.Online.Adapter.CreateSTRING(this, "", "LastName");
			_Age = @Connector.Online.Adapter.CreateINT(this, "", "Age");
			_Birthday = @Connector.Online.Adapter.CreateDATE(this, "", "Birthday");
			_BirthTown = @Connector.Online.Adapter.CreateSTRING(this, "", "BirthTown");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Person()
		{
			PexPreConstructorParameterless();
			_FirstName = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_LastName = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Age = Vortex.Connector.IConnectorFactory.CreateINT();
			_Birthday = Vortex.Connector.IConnectorFactory.CreateDATE();
			_BirthTown = Vortex.Connector.IConnectorFactory.CreateSTRING();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPerson
	{
		public void CopyPlainToCyclic(Plc.Person target)
		{
			target.FirstName.Cyclic = FirstName;
			target.LastName.Cyclic = LastName;
			target.Age.Cyclic = Age;
			target.Birthday.Cyclic = Birthday;
			target.BirthTown.Cyclic = BirthTown;
		}

		public void CopyPlainToCyclic(Plc.IPerson target)
		{
			this.CopyPlainToCyclic((Plc.Person)target);
		}

		public void CopyPlainToShadow(Plc.Person target)
		{
			target.FirstName.Shadow = FirstName;
			target.LastName.Shadow = LastName;
			target.Age.Shadow = Age;
			target.Birthday.Shadow = Birthday;
			target.BirthTown.Shadow = BirthTown;
		}

		public void CopyPlainToShadow(Plc.IShadowPerson target)
		{
			this.CopyPlainToShadow((Plc.Person)target);
		}

		public void CopyCyclicToPlain(Plc.Person source)
		{
			FirstName = source.FirstName.LastValue;
			LastName = source.LastName.LastValue;
			Age = source.Age.LastValue;
			Birthday = source.Birthday.LastValue;
			BirthTown = source.BirthTown.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IPerson source)
		{
			this.CopyCyclicToPlain((Plc.Person)source);
		}

		public void CopyShadowToPlain(Plc.Person source)
		{
			FirstName = source.FirstName.Shadow;
			LastName = source.LastName.Shadow;
			Age = source.Age.Shadow;
			Birthday = source.Birthday.Shadow;
			BirthTown = source.BirthTown.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowPerson source)
		{
			this.CopyShadowToPlain((Plc.Person)source);
		}
	}
}