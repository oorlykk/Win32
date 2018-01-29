using System;

namespace Win32
{
	public struct WNDCLASS
	{
		public int style;

		public int lpfnwndproc;

		public int cbClsextra;

		public int cbWndExtra2;

		public IntPtr hInstance;

		public IntPtr hIcon;

		public IntPtr hCursor;

		public IntPtr hbrBackground;

		public string lpszMenuName;

		public string lpszClassName;
	}
}
