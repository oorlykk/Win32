using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct HANDLETABLE
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public int objectHandle;
	}
}
