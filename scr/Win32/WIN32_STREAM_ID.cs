using System;

namespace Win32
{
	public struct WIN32_STREAM_ID
	{
		public int dwStreamID;

		public int dwStreamAttributes;

		public int dwStreamSizeLow;

		public int dwStreamSizeHigh;

		public int dwStreamNameSize;

		public byte cStreamName;
	}
}
