using System;

namespace Win32
{
	public struct MCI_BREAK_PARMS
	{
		public int dwCallback;

		public int nVirtKey;

		public IntPtr hwndBreak;
	}
}
