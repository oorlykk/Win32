using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct TARGET
	{
		public int dwType;

		public int dwDeviceID;

		public short wMid;

		public short wPid;

		public int vDriverVersion;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szPname;
	}
}
