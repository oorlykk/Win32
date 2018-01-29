using System;

namespace Win32
{
	public struct SHELLEXECUTEINFO
	{
		public int cbSize;

		public int fMask;

		public IntPtr hwnd;

		public string lpVerb;

		public string lpFile;

		public string lpParameters;

		public string lpDirectory;

		public int nShow;

		public IntPtr hInstApp;

		public int lpIDList;

		public string lpClass;

		public IntPtr hkeyClass;

		public int dwHotKey;

		public IntPtr hIcon;

		public IntPtr hProcess;
	}
}
