using System;

namespace Win32
{
	public struct APPBARDATA
	{
		public int cbSize;

		public IntPtr hwnd;

		public int uCallbackMessage;

		public int uEdge;

		public RECT rc;

		public int lParam;
	}
}
