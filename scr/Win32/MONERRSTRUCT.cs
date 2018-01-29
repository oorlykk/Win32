using System;

namespace Win32
{
	public struct MONERRSTRUCT
	{
		public int cb;

		public int wLastError;

		public int dwTime;

		public IntPtr htask;
	}
}
