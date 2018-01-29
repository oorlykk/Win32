using System;

namespace Win32
{
	public struct MEMORYSTATUS
	{
		public int dwLength;

		public int dwMemoryLoad;

		public int dwTotalPhys;

		public int dwAvailPhys;

		public int dwTotalPageFile;

		public int dwAvailPageFile;

		public int dwTotalVirtual;

		public int dwAvailVirtual;
	}
}
