using System;

namespace Win32
{
	public struct RGNDATAHEADER
	{
		public int dwSize;

		public int iType;

		public int nCount;

		public int nRgnSize;

		public RECT rcBound;
	}
}
