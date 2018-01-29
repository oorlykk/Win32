using System;

namespace Win32
{
	public struct EVENTLOGRECORD
	{
		public int Length;

		public int Reserved;

		public int RecordNumber;

		public int TimeGenerated;

		public int TimeWritten;

		public int EventID;

		public short EventType;

		public short NumStrings;

		public short EventCategory;

		public short ReservedFlags;

		public int ClosingRecordNumber;

		public int StringOffset;

		public int UserSidLength;

		public int UserSidOffset;

		public int DataLength;

		public int DataOffset;
	}
}
