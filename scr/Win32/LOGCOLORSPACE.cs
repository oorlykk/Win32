using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct LOGCOLORSPACE
	{
		public int lcsSignature;

		public int lcsVersion;

		public int lcsSize;

		public int lcsCSType;

		public int lcsIntent;

		public CIEXYZTRIPLE lcsEndPoints;

		public int lcsGammaRed;

		public int lcsGammaGreen;

		public int lcsGammaBlue;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string lcsFileName;
	}
}
