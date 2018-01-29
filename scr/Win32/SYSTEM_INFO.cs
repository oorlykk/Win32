using System;

namespace Win32
{
	public struct SYSTEM_INFO
	{
		public int dwOemID;

		public int dwPageSize;

		public int lpMinimumApplicationAddress;

		public int lpMaximumApplicationAddress;

		public int dwActiveProcessorMask;

		public int dwNumberOrfProcessors;

		public int dwProcessorType;

		public int dwAllocationGranularity;

		public int dwReserved;
	}
}
