using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct EXCEPTION_RECORD
	{
		public int ExceptionCode;

		public int ExceptionFlags;

		public int pExceptionRecord;

		public int ExceptionAddress;

		public int NumberParameters;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
		public int[] ExceptionInformation;
	}
}
