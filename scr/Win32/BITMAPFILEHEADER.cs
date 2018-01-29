using System;

namespace Win32
{
	public struct BITMAPFILEHEADER
	{
		public short bfType;

		public int bfSize;

		public short bfReserved1;

		public short bfReserved2;

		public int bfOffBits;
	}
}
