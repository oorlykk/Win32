using System;

namespace Win32
{
	public struct ENHMETAHEADER
	{
		public int iType;

		public int nSize;

		public RECT rclBounds;

		public RECT rclFrame;

		public int dSignature;

		public int nVersion;

		public int nBytes;

		public int nRecords;

		public short nHandles;

		public short sReserved;

		public int nDescription;

		public int offDescription;

		public int nPalEntries;

		public SIZE szlDevice;

		public SIZE szlMillimeters;
	}
}
