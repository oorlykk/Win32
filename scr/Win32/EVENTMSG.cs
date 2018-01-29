using System;

namespace Win32
{
	public struct EVENTMSG
	{
		public int message;

		public int paramL;

		public int paramH;

		public int time;

		public IntPtr hwnd;
	}
}
