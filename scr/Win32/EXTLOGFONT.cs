using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct EXTLOGFONT
	{
		public LOGFONT elfLogFont;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] elfFullName;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] elfStyle;

		public int elfVersion;

		public int elfStyleSize;

		public int elfMatch;

		public int elfReserved;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] elfVendorId;

		public int elfCulture;

		public PANOSE elfPanose;
	}
}
