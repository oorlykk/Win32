using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct FONTSIGNATURE
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public int fsUsb;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public int fsCsb;
	}
}
