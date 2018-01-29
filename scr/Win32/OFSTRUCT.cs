using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct OFSTRUCT
	{
		public byte cBytes;

		public byte fFixedDisk;

		public short nErrCode;

		public short Reserved1;

		public short Reserved2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		public byte[] szPathName;
	}
}
