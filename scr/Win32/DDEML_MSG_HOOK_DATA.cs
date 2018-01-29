using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct DDEML_MSG_HOOK_DATA
	{
		public int uiLo;

		public int uiHi;

		public int cbData;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public int Data;
	}
}
