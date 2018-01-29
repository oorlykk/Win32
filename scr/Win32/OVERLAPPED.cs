using System;

namespace Win32
{
	public struct OVERLAPPED
	{
		public int Internal;

		public int InternalHigh;

		public int offset;

		public int OffsetHigh;

		public IntPtr hEvent;
	}
}
