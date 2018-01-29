using System;

namespace Win32
{
	public struct MCI_OPEN_PARMS
	{
		public int dwCallback;

		public int wDeviceID;

		public string lpstrDeviceType;

		public string lpstrElementName;

		public string lpstrAlias;
	}
}
