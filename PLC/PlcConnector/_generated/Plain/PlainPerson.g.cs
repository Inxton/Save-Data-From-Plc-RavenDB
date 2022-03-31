using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPerson : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String _FirstName;
		public System.String FirstName
		{
			get
			{
				return _FirstName;
			}

			set
			{
				if (_FirstName != value)
				{
					_FirstName = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(FirstName)));
				}
			}
		}

		System.String _LastName;
		public System.String LastName
		{
			get
			{
				return _LastName;
			}

			set
			{
				if (_LastName != value)
				{
					_LastName = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LastName)));
				}
			}
		}

		System.Int16 _Age;
		public System.Int16 Age
		{
			get
			{
				return _Age;
			}

			set
			{
				if (_Age != value)
				{
					_Age = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Age)));
				}
			}
		}

		System.DateTime _Birthday;
		public System.DateTime Birthday
		{
			get
			{
				return _Birthday;
			}

			set
			{
				if (_Birthday != value)
				{
					_Birthday = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Birthday)));
				}
			}
		}

		System.String _BirthTown;
		public System.String BirthTown
		{
			get
			{
				return _BirthTown;
			}

			set
			{
				if (_BirthTown != value)
				{
					_BirthTown = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BirthTown)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainPerson()
		{
		}
	}
}