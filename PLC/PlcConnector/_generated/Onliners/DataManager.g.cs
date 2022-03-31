using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "DataManager", "Plc", TypeComplexityEnum.Complex)]
	public partial class DataManager : TcoData.TcoDataExchange, Vortex.Connector.IVortexObject, IDataManager, IShadowDataManager, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Data __data;
		public Data _data
		{
			get
			{
				return __data;
			}
		}

		IData IDataManager._data
		{
			get
			{
				return _data;
			}
		}

		IShadowData IShadowDataManager._data
		{
			get
			{
				return _data;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			_data.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			_data.LazyShadowToOnline();
		}

		public new PlainDataManager CreatePlainerType()
		{
			var cloned = new PlainDataManager();
			base.CreatePlainerType(cloned);
			cloned._data = _data.CreatePlainerType();
			return cloned;
		}

		protected PlainDataManager CreatePlainerType(PlainDataManager cloned)
		{
			base.CreatePlainerType(cloned);
			cloned._data = _data.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc.PlainDataManager source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainDataManager source)
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

		public void FlushOnlineToPlain(Plc.PlainDataManager source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public DataManager(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__data = new Data(this, "", "_data");
			PexConstructor(parent, readableTail, symbolTail);
		}

		public DataManager(): base ()
		{
			PexPreConstructorParameterless();
			__data = new Data();
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDataManager
	{
		public void CopyPlainToCyclic(Plc.DataManager target)
		{
			base.CopyPlainToCyclic(target);
			_data.CopyPlainToCyclic(target._data);
		}

		public void CopyPlainToCyclic(Plc.IDataManager target)
		{
			this.CopyPlainToCyclic((Plc.DataManager)target);
		}

		public void CopyPlainToShadow(Plc.DataManager target)
		{
			base.CopyPlainToShadow(target);
			_data.CopyPlainToShadow(target._data);
		}

		public void CopyPlainToShadow(Plc.IShadowDataManager target)
		{
			this.CopyPlainToShadow((Plc.DataManager)target);
		}

		public void CopyCyclicToPlain(Plc.DataManager source)
		{
			base.CopyCyclicToPlain(source);
			_data.CopyCyclicToPlain(source._data);
		}

		public void CopyCyclicToPlain(Plc.IDataManager source)
		{
			this.CopyCyclicToPlain((Plc.DataManager)source);
		}

		public void CopyShadowToPlain(Plc.DataManager source)
		{
			base.CopyShadowToPlain(source);
			_data.CopyShadowToPlain(source._data);
		}

		public void CopyShadowToPlain(Plc.IShadowDataManager source)
		{
			this.CopyShadowToPlain((Plc.DataManager)source);
		}
	}
}