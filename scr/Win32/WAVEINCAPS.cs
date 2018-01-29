using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct WAVEINCAPS
	{
		public short wMid;

		public short wPid;

		public int vDriverVersion;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szPname;

		public int dwFormats;

		public short wChannels;
	}
}
