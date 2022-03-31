using System;

namespace PlcDocu.Plc
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Person
	{
		public object FirstName;
		public object LastName;
		public object Age;
		public object Birthday;
		public object BirthTown;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Person()
		{
		}
	}
#endif
}