using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct JOYCAPS
	{
		public short wMid;

		public short wPid;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szPname;

		public short wXmin;

		public short wXmax;

		public short wYmin;

		public short wYmax;

		public short wZmin;

		public short wZmax;

		public short wNumButtons;

		public short wPeriodMin;

		public short wPeriodMax;
	}
}
