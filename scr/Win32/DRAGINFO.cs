using System;

namespace Win32
{
	public struct DRAGINFO
	{
		public int uSize;

		public POINT pt;

		public int fNC;

		public string lpFileList;

		public int grfKeyState;
	}
}
