using System;

namespace Win32
{
	public struct CREATE_PROCESS_DEBUG_INFO
	{
		public IntPtr hFile;

		public IntPtr hProcess;

		public IntPtr hThread;

		public int lpBaseOfImage;

		public int dwDebugInfoFileOffset;

		public int nDebugInfoSize;

		public int lpThreadLocalBase;

		public int lpStartAddress;

		public int lpImageName;

		public short fUnicode;
	}
}
