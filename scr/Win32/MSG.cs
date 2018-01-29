using System;

namespace Win32
{
	public struct MSG
	{
		public IntPtr hwnd;

		public int message;

		public int wParam;

		public int lParam;

		public int time;

		public POINT pt;
	}
}
