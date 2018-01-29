using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct MONCBSTRUCT
	{
		public int cb;

		public int dwTime;

		public IntPtr htask;

		public int dwRet;

		public int wType;

		public int wFmt;

		public IntPtr hConv;

		public IntPtr hsz1;

		public IntPtr hsz2;

		public IntPtr hData;

		public int dwData1;

		public int dwData2;

		public CONVCONTEXT cc;

		public int cbData;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public int Data;
	}
}
