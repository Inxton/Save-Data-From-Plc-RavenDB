using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainData : TcoData.PlainTcoEntity
	{
		System.String _DataId;
		public System.String DataId
		{
			get
			{
				return _DataId;
			}

			set
			{
				if (_DataId != value)
				{
					_DataId = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DataId)));
				}
			}
		}

		PlainPerson _Person_0;
		public PlainPerson Person_0
		{
			get
			{
				return _Person_0;
			}

			set
			{
				if (_Person_0 != value)
				{
					_Person_0 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_0)));
				}
			}
		}

		PlainPerson _Person_1;
		public PlainPerson Person_1
		{
			get
			{
				return _Person_1;
			}

			set
			{
				if (_Person_1 != value)
				{
					_Person_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_1)));
				}
			}
		}

		PlainPerson _Person_2;
		public PlainPerson Person_2
		{
			get
			{
				return _Person_2;
			}

			set
			{
				if (_Person_2 != value)
				{
					_Person_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_2)));
				}
			}
		}

		PlainPerson _Person_3;
		public PlainPerson Person_3
		{
			get
			{
				return _Person_3;
			}

			set
			{
				if (_Person_3 != value)
				{
					_Person_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_3)));
				}
			}
		}

		PlainPerson _Person_4;
		public PlainPerson Person_4
		{
			get
			{
				return _Person_4;
			}

			set
			{
				if (_Person_4 != value)
				{
					_Person_4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_4)));
				}
			}
		}

		PlainPerson _Person_5;
		public PlainPerson Person_5
		{
			get
			{
				return _Person_5;
			}

			set
			{
				if (_Person_5 != value)
				{
					_Person_5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_5)));
				}
			}
		}

		PlainPerson _Person_6;
		public PlainPerson Person_6
		{
			get
			{
				return _Person_6;
			}

			set
			{
				if (_Person_6 != value)
				{
					_Person_6 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_6)));
				}
			}
		}

		PlainPerson _Person_7;
		public PlainPerson Person_7
		{
			get
			{
				return _Person_7;
			}

			set
			{
				if (_Person_7 != value)
				{
					_Person_7 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_7)));
				}
			}
		}

		PlainPerson _Person_8;
		public PlainPerson Person_8
		{
			get
			{
				return _Person_8;
			}

			set
			{
				if (_Person_8 != value)
				{
					_Person_8 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_8)));
				}
			}
		}

		PlainPerson _Person_9;
		public PlainPerson Person_9
		{
			get
			{
				return _Person_9;
			}

			set
			{
				if (_Person_9 != value)
				{
					_Person_9 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Person_9)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainData()
		{
			_Person_0 = new PlainPerson();
			_Person_1 = new PlainPerson();
			_Person_2 = new PlainPerson();
			_Person_3 = new PlainPerson();
			_Person_4 = new PlainPerson();
			_Person_5 = new PlainPerson();
			_Person_6 = new PlainPerson();
			_Person_7 = new PlainPerson();
			_Person_8 = new PlainPerson();
			_Person_9 = new PlainPerson();
		}
	}
}