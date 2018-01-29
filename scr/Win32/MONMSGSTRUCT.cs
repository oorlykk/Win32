using System;

namespace Win32
{
	public struct MONMSGSTRUCT
	{
		public int cb;

		public IntPtr hwndTo;

		public int dwTime;

		public IntPtr htask;

		public int wMsg;

		public int wParam;

		public int lParam;

		public DDEML_MSG_HOOK_DATA dmhd;
	}
}
