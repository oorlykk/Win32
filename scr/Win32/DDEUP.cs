using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct DDEUP
	{
		public short unused;

		public short fAck;

		public short fRelease;

		public short fReserved;

		public short fAckReq;

		public short cfFormat;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public byte rgb;
	}
}
