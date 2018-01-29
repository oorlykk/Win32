using System;

namespace Win32
{
	public struct MCI_SYSINFO_PARMS
	{
		public int dwCallback;

		public string lpstrReturn;

		public int dwRetSize;

		public int dwNumber;

		public int wDeviceType;
	}
}
