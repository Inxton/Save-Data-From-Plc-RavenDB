using System;

namespace PlcDocu.Plc
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Data : PlcDocu.TcoData.TcoEntity
	{
		public object DataId;
		public Person Person_0;
		public Person Person_1;
		public Person Person_2;
		public Person Person_3;
		public Person Person_4;
		public Person Person_5;
		public Person Person_6;
		public Person Person_7;
		public Person Person_8;
		public Person Person_9;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Data()
		{
		}
	}
#endif
}