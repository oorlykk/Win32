using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct PRIVILEGE_SET
	{
		public int PrivilegeCount;

		public int Control;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privilege;
	}
}
