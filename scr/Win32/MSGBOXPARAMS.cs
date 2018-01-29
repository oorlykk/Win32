using System;

namespace Win32
{
	public struct MSGBOXPARAMS
	{
		public int cbSize;

		public IntPtr hwndOwner;

		public IntPtr hInstance;

		public string lpszText;

		public string lpszCaption;

		public int dwStyle;

		public string lpszIcon;

		public int dwContextHelpId;

		public int lpfnMsgBoxCallback;

		public int dwLanguageId;
	}
}
