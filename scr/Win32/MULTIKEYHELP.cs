using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct MULTIKEYHELP
	{
		public int mkSize;

		public byte mkKeylist;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 253)]
		public string szKeyphrase;
	}
}
