using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct MIDIEVENT
	{
		public int dwDeltaTime;

		public int dwStreamID;

		public int dwEvent;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public int dwParms;
	}
}
