using System;

namespace Win32
{
	public struct WAVEHDR
	{
		public string lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public int dwUser;

		public int dwFlags;

		public int dwLoops;

		public int lpNext;

		public int Reserved;
	}
}
