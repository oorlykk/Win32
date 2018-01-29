using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct TOKEN_GROUPS
	{
		public int GroupCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public SID_AND_ATTRIBUTES[] Groups;
	}
}
