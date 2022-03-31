using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainApp : TcoCore.PlainTcoContext
	{
		System.Int16 _Step;
		public System.Int16 Step
		{
			get
			{
				return _Step;
			}

			set
			{
				if (_Step != value)
				{
					_Step = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Step)));
				}
			}
		}

		TcoCore.PlainTcoRemoteTask _GenerateDataTask;
		public TcoCore.PlainTcoRemoteTask GenerateDataTask
		{
			get
			{
				return _GenerateDataTask;
			}

			set
			{
				if (_GenerateDataTask != value)
				{
					_GenerateDataTask = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(GenerateDataTask)));
				}
			}
		}

		PlainDataManager _DataManager;
		public PlainDataManager DataManager
		{
			get
			{
				return _DataManager;
			}

			set
			{
				if (_DataManager != value)
				{
					_DataManager = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DataManager)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainApp()
		{
			_GenerateDataTask = new TcoCore.PlainTcoRemoteTask();
			_DataManager = new PlainDataManager();
		}
	}
}