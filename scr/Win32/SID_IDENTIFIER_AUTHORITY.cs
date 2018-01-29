using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct SID_IDENTIFIER_AUTHORITY
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public byte[] Value;
	}
}
