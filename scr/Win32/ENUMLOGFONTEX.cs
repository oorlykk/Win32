using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct ENUMLOGFONTEX
	{
		public LOGFONT elfLogFont;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] elfFullName;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] elfStyle;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] elfScript;
	}
}
