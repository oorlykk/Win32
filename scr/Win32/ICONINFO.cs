using System;

namespace Win32
{
	public struct ICONINFO
	{
		public int fIcon;

		public int xHotspot;

		public int yHotspot;

		public IntPtr hbmMask;

		public IntPtr hbmColor;
	}
}
