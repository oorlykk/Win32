using System;

namespace Win32
{
	public struct MCI_OVLY_SAVE_PARMS
	{
		public int dwCallback;

		public string lpFileName;

		public RECT rc;
	}
}
