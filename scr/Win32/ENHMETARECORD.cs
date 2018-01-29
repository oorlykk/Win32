using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct ENHMETARECORD
	{
		public int iType;

		public int nSize;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public int dParm;
	}
}
