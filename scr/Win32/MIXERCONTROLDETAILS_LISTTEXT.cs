using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct MIXERCONTROLDETAILS_LISTTEXT
	{
		public int dwParam1;

		public int dwParam2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string szName;
	}
}
