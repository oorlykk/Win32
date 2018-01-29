using System;

namespace Win32
{
	public struct DEBUGHOOKINFO
	{
		public IntPtr hModuleHook;

		public int Reserved;

		public int lParam;

		public int wParam;

		public int code;
	}
}
