using System;

namespace PlcDocu.Plc
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class DataManager : PlcDocu.TcoData.TcoDataExchange
	{
		public Data _data;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public DataManager()
		{
		}
	}
#endif
}