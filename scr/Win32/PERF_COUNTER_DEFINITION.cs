using System;

namespace Win32
{
	public struct PERF_COUNTER_DEFINITION
	{
		public int ByteLength;

		public int CounterNameTitleIndex;

		public string CounterNameTitle;

		public int CounterHelpTitleIndex;

		public string CounterHelpTitle;

		public int DefaultScale;

		public int DetailLevel;

		public int CounterType;

		public int CounterSize;

		public int CounterOffset;
	}
}
