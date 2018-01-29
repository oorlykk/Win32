using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct COMMPROP
	{
		public short wPacketLength;

		public short wPacketVersion;

		public int dwServiceMask;

		public int dwReserved1;

		public int dwMaxTxQueue;

		public int dwMaxRxQueue;

		public int dwMaxBaud;

		public int dwProvSubType;

		public int dwProvCapabilities;

		public int dwSettableParams;

		public int dwSettableBaud;

		public short wSettableData;

		public short wSettableStopParity;

		public int dwCurrentTxQueue;

		public int dwCurrentRxQueue;

		public int dwProvSpec1;

		public int dwProvSpec2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public short[] wcProvChar;
	}
}
