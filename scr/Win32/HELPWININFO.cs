using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct HELPWININFO
	{
		public int wStructSize;

		public int x;

		public int y;

		public int dx;

		public int dy;

		public int wMax;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
		public string rgchMember;
	}
}
