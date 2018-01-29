using System;

namespace Win32
{
	public struct WINDOWPLACEMENT
	{
		public int Length;

		public int flags;

		public int showCmd;

		public POINT ptMinPosition;

		public POINT ptMaxPosition;

		public RECT rcNormalPosition;
	}
}
