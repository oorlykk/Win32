using System;

namespace Win32
{
	public struct MCI_WAVE_SET_PARMS
	{
		public int dwCallback;

		public int dwTimeFormat;

		public int dwAudio;

		public int wInput;

		public int wOutput;

		public short wFormatTag;

		public short wReserved2;

		public short nChannels;

		public short wReserved3;

		public int nSamplesPerSec;

		public int nAvgBytesPerSec;

		public short nBlockAlign;

		public short wReserved4;

		public short wBitsPerSample;

		public short wReserved5;
	}
}
