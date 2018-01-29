using System;

namespace Win32
{
	public struct METAHEADER
	{
		public short mtType;

		public short mtHeaderSize;

		public short mtVersion;

		public int mtSize;

		public short mtNoObjects;

		public int mtMaxRecord;

		public short mtNoParameters;
	}
}
