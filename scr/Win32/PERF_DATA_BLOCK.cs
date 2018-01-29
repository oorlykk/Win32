using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct PERF_DATA_BLOCK
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public string Signature;

		public int LittleEndian;

		public int Version;

		public int Revision;

		public int TotalByteLength;

		public int HeaderLength;

		public int NumObjectTypes;

		public int DefaultObject;

		public SYSTEMTIME SystemTime;

		public LARGE_INTEGER PerfTime;

		public LARGE_INTEGER PerfFreq;

		public LARGE_INTEGER PerTime100nSec;

		public int SystemNameLength;

		public int SystemNameOffset;
	}
}
