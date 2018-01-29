using System;

namespace Win32
{
	public struct NEWTEXTMETRIC
	{
		public int tmHeight;

		public int tmAscent;

		public int tmDescent;

		public int tmInternalLeading;

		public int tmExternalLeading;

		public int tmAveCharWidth;

		public int tmMaxCharWidth;

		public int tmWeight;

		public int tmOverhang;

		public int tmDigitizedAspectX;

		public int tmDigitizedAspectY;

		public byte tmFirstChar;

		public byte tmLastChar;

		public byte tmDefaultChar;

		public byte tmBreakChar;

		public byte tmItalic;

		public byte tmUnderlined;

		public byte tmStruckOut;

		public byte tmPitchAndFamily;

		public byte tmCharSet;

		public int ntmFlags;

		public int ntmSizeEM;

		public int ntmCellHeight;

		public int ntmAveWidth;
	}
}
