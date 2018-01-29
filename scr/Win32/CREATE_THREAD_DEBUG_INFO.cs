using System;

namespace Win32
{
	public struct CREATE_THREAD_DEBUG_INFO
	{
		public IntPtr hThread;

		public int lpThreadLocalBase;

		public int lpStartAddress;
	}
}
