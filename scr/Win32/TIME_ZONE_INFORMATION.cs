using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct TIME_ZONE_INFORMATION
	{
		public int Bias;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public short[] StandardName;

		public SYSTEMTIME StandardDate;

		public int StandardBias;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public short[] DaylightName;

		public SYSTEMTIME DaylightDate;

		public int DaylightBias;
	}
}
