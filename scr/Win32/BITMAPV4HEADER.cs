using System;

namespace Win32
{
	public struct BITMAPV4HEADER
	{
		public int bV4Size;

		public int bV4Width;

		public int bV4Height;

		public short bV4Planes;

		public short bV4BitCount;

		public int bV4V4Compression;

		public int bV4SizeImage;

		public int bV4XPelsPerMeter;

		public int bV4YPelsPerMeter;

		public int bV4ClrUsed;

		public int bV4ClrImportant;

		public int bV4RedMask;

		public int bV4GreenMask;

		public int bV4BlueMask;

		public int bV4AlphaMask;

		public int bV4CSType;

		public int bV4Endpoints;

		public int bV4GammaRed;

		public int bV4GammaGreen;

		public int bV4GammaBlue;
	}
}
