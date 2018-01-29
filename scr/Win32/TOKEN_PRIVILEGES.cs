using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct TOKEN_PRIVILEGES
	{
		public int PrivilegeCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privileges;
	}
}
