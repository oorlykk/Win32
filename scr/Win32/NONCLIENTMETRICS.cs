using System;

namespace Win32
{
	public struct NONCLIENTMETRICS
	{
		public int cbSize;

		public int iBorderWidth;

		public int iScrollWidth;

		public int iScrollHeight;

		public int iCaptionWidth;

		public int iCaptionHeight;

		public LOGFONT lfCaptionFont;

		public int iSMCaptionWidth;

		public int iSMCaptionHeight;

		public LOGFONT lfSMCaptionFont;

		public int iMenuWidth;

		public int iMenuHeight;

		public LOGFONT lfMenuFont;

		public LOGFONT lfStatusFont;

		public LOGFONT lfMessageFont;
	}
}
