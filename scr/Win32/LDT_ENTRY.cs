using System;

namespace Win32
{
	public struct LDT_ENTRY
	{
		public short LimitLow;

		public short BaseLow;

		public int HighWord;
	}
}
