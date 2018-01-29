using System;

namespace Win32
{
	public struct OUTLINETEXTMETRIC
	{
		public int otmSize;

		public TEXTMETRIC otmTextMetrics;

		public byte otmFiller;

		public PANOSE otmPanoseNumber;

		public int otmfsSelection;

		public int otmfsType;

		public int otmsCharSlopeRise;

		public int otmsCharSlopeRun;

		public int otmItalicAngle;

		public int otmEMSquare;

		public int otmAscent;

		public int otmDescent;

		public int otmLineGap;

		public int otmsCapEmHeight;

		public int otmsXHeight;

		public RECT otmrcFontBox;

		public int otmMacAscent;

		public int otmMacDescent;

		public int otmMacLineGap;

		public int otmusMinimumPPEM;

		public POINT otmptSubscriptSize;

		public POINT otmptSubscriptOffset;

		public POINT otmptSuperscriptSize;

		public POINT otmptSuperscriptOffset;

		public int otmsStrikeoutSize;

		public int otmsStrikeoutPosition;

		public int otmsUnderscorePosition;

		public int otmsUnderscoreSize;

		public string otmpFamilyName;

		public string otmpFaceName;

		public string otmpStyleName;

		public string otmpFullName;
	}
}
