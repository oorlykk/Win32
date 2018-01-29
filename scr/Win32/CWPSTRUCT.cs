using System;

namespace Win32
{
	public struct CWPSTRUCT
	{
		public int lParam;

		public int wParam;

		public int message;

		public IntPtr hwnd;
	}
}
