using System;

namespace Win32
{
	public struct MDICREATESTRUCT
	{
		public string szClass;

		public string szTitle;

		public IntPtr hOwner;

		public int x;

		public int y;

		public int cx;

		public int cy;

		public int style;

		public int lParam;
	}
}
