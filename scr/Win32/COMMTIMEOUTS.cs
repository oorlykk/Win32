using System;

namespace Win32
{
	public struct COMMTIMEOUTS
	{
		public int ReadIntervalTimeout;

		public int ReadTotalTimeoutMultiplier;

		public int ReadTotalTimeoutConstant;

		public int WriteTotalTimeoutMultiplier;

		public int WriteTotalTimeoutConstant;
	}
}
