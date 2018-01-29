using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct LOCALESIGNATURE
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public int lsUsb;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public int lsCsbDefault;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public int lsCsbSupported;
	}
}
