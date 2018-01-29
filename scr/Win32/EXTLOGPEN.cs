using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct EXTLOGPEN
	{
		public int elpPenStyle;

		public int elpWidth;

		public int elpBrushStyle;

		public int elpColor;

		public int elpHatch;

		public int elpNumEntries;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public int elpStyleEntry;
	}
}
