using System;

namespace Win32
{
	public struct BROWSEINFO
	{
		public IntPtr hwndOwner;

		public int pIDLRoot;

		public int pszDisplayName;

		public int lpszTitle;

		public int ulFlags;

		public int lpfnCallback;

		public int lParam;

		public int iImage;
	}
}
