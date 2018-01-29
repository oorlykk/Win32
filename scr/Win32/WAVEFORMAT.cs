using System;

namespace Win32
{
	public struct WAVEFORMAT
	{
		public short wFormatTag;

		public short nChannels;

		public int nSamplesPerSec;

		public int nAvgBytesPerSec;

		public short nBlockAlign;
	}
}
