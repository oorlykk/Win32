using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct AUXCAPS
	{
		public short wMid;

		public short wPid;

		public int vDriverVersion;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szPname;

		public short wTechnology;

		public int dwSupport;
	}
}
