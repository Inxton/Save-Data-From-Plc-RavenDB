using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDataManager : TcoData.PlainTcoDataExchange
	{
		PlainData __data;
		public PlainData _data
		{
			get
			{
				return __data;
			}

			set
			{
				if (__data != value)
				{
					__data = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_data)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainDataManager()
		{
			__data = new PlainData();
		}
	}
}