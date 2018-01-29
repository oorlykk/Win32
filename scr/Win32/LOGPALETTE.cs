using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct LOGPALETTE
	{
		public short palVersion;

		public short palNumEntries;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public PALETTEENTRY palPalEntry;
	}
}
