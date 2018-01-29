using System;

namespace Win32
{
	public struct SCROLLINFO
	{
		public int cbSize;

		public int fMask;

		public int nMin;

		public int nMax;

		public int nPage;

		public int nPos;

		public int nTrackPos;
	}
}
