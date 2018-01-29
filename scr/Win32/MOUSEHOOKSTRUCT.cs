using System;

namespace Win32
{
	public struct MOUSEHOOKSTRUCT
	{
		public POINT pt;

		public IntPtr hwnd;

		public int wHitTestCode;

		public int dwExtraInfo;
	}
}
