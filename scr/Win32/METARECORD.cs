using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct METARECORD
	{
		public int rdSize;

		public short rdFunction;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public short rdParm;
	}
}
