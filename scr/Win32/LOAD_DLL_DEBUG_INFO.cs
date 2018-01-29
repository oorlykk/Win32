using System;

namespace Win32
{
	public struct LOAD_DLL_DEBUG_INFO
	{
		public IntPtr hFile;

		public int lpBaseOfDll;

		public int dwDebugInfoFileOffset;

		public int nDebugInfoSize;

		public int lpImageName;

		public short fUnicode;
	}
}
