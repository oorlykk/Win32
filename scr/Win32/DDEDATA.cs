using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct DDEDATA
	{
		public short unused;

		public short fresponse;

		public short fRelease;

		public short Reserved;

		public short fAckReq;

		public short cfFormat;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public byte Value;
	}
}
