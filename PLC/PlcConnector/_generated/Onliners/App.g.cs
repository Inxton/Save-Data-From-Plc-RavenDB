using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "App", "Plc", TypeComplexityEnum.Complex)]
	public partial class App : TcoCore.TcoContext, Vortex.Connector.IVortexObject, IApp, IShadowApp, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerInt _Step;
		public Vortex.Connector.ValueTypes.OnlinerInt Step
		{
			get
			{
				return _Step;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IApp.Step
		{
			get
			{
				return Step;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowApp.Step
		{
			get
			{
				return Step;
			}
		}

		TcoCore.TcoRemoteTask _GenerateDataTask;
		public TcoCore.TcoRemoteTask GenerateDataTask
		{
			get
			{
				return _GenerateDataTask;
			}
		}

		TcoCore.ITcoRemoteTask IApp.GenerateDataTask
		{
			get
			{
				return GenerateDataTask;
			}
		}

		TcoCore.IShadowTcoRemoteTask IShadowApp.GenerateDataTask
		{
			get
			{
				return GenerateDataTask;
			}
		}

		DataManager _DataManager;
		public DataManager DataManager
		{
			get
			{
				return _DataManager;
			}
		}

		IDataManager IApp.DataManager
		{
			get
			{
				return DataManager;
			}
		}

		IShadowDataManager IShadowApp.DataManager
		{
			get
			{
				return DataManager;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Step.Shadow = Step.LastValue;
			GenerateDataTask.LazyOnlineToShadow();
			DataManager.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Step.Cyclic = Step.Shadow;
			GenerateDataTask.LazyShadowToOnline();
			DataManager.LazyShadowToOnline();
		}

		public new PlainApp CreatePlainerType()
		{
			var cloned = new PlainApp();
			base.CreatePlainerType(cloned);
			cloned.GenerateDataTask = GenerateDataTask.CreatePlainerType();
			cloned.DataManager = DataManager.CreatePlainerType();
			return cloned;
		}

		protected PlainApp CreatePlainerType(PlainApp cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.GenerateDataTask = GenerateDataTask.CreatePlainerType();
			cloned.DataManager = DataManager.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc.PlainApp source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainApp source)
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

		public void FlushOnlineToPlain(Plc.PlainApp source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public App(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Step = @Connector.Online.Adapter.CreateINT(this, "", "Step");
			_GenerateDataTask = new TcoCore.TcoRemoteTask(this, "", "GenerateDataTask");
			_DataManager = new DataManager(this, "", "DataManager");
			PexConstructor(parent, readableTail, symbolTail);
		}

		public App(): base ()
		{
			PexPreConstructorParameterless();
			_Step = Vortex.Connector.IConnectorFactory.CreateINT();
			_GenerateDataTask = new TcoCore.TcoRemoteTask();
			_DataManager = new DataManager();
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainApp
	{
		public void CopyPlainToCyclic(Plc.App target)
		{
			base.CopyPlainToCyclic(target);
			target.Step.Cyclic = Step;
			GenerateDataTask.CopyPlainToCyclic(target.GenerateDataTask);
			DataManager.CopyPlainToCyclic(target.DataManager);
		}

		public void CopyPlainToCyclic(Plc.IApp target)
		{
			this.CopyPlainToCyclic((Plc.App)target);
		}

		public void CopyPlainToShadow(Plc.App target)
		{
			base.CopyPlainToShadow(target);
			target.Step.Shadow = Step;
			GenerateDataTask.CopyPlainToShadow(target.GenerateDataTask);
			DataManager.CopyPlainToShadow(target.DataManager);
		}

		public void CopyPlainToShadow(Plc.IShadowApp target)
		{
			this.CopyPlainToShadow((Plc.App)target);
		}

		public void CopyCyclicToPlain(Plc.App source)
		{
			base.CopyCyclicToPlain(source);
			Step = source.Step.LastValue;
			GenerateDataTask.CopyCyclicToPlain(source.GenerateDataTask);
			DataManager.CopyCyclicToPlain(source.DataManager);
		}

		public void CopyCyclicToPlain(Plc.IApp source)
		{
			this.CopyCyclicToPlain((Plc.App)source);
		}

		public void CopyShadowToPlain(Plc.App source)
		{
			base.CopyShadowToPlain(source);
			Step = source.Step.Shadow;
			GenerateDataTask.CopyShadowToPlain(source.GenerateDataTask);
			DataManager.CopyShadowToPlain(source.DataManager);
		}

		public void CopyShadowToPlain(Plc.IShadowApp source)
		{
			this.CopyShadowToPlain((Plc.App)source);
		}
	}
}