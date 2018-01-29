using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct MIXERCONTROL
	{
		public int cbStruct;

		public int dwControlID;

		public int dwControlType;

		public int fdwControl;

		public int cMultipleItems;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string szShortName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string szName;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public int[] Bounds;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public int[] Metrics;
	}
}
