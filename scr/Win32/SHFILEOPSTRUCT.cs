using System;

namespace Win32
{
	public struct SHFILEOPSTRUCT
	{
		public IntPtr hwnd;

		public int wFunc;

		public string pFrom;

		public string pTo;

		public short fFlags;

		public int fAnyOperationsAborted;

		public IntPtr hNameMappings;

		public string lpszProgressTitle;
	}
}
