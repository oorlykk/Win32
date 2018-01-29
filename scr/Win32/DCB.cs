using System;

namespace Win32
{
	public struct DCB
	{
		public int DCBlength;

		public int BaudRate;

		public int fBitFields;

		public short wReserved;

		public short XonLim;

		public short XoffLim;

		public byte ByteSize;

		public byte Parity;

		public byte StopBits;

		public byte XonChar;

		public byte XoffChar;

		public byte ErrorChar;

		public byte EofChar;

		public byte EvtChar;

		public short wReserved1;
	}
}
