using System;

namespace Win32
{
	public struct PERF_OBJECT_TYPE
	{
		public int TotalByteLength;

		public int DefinitionLength;

		public int HeaderLength;

		public int ObjectNameTitleIndex;

		public string ObjectNameTitle;

		public int ObjectHelpTitleIndex;

		public string ObjectHelpTitle;

		public int DetailLevel;

		public int NumCounters;

		public int DefaultCounter;

		public int NumInstances;

		public int CodePage;

		public LARGE_INTEGER PerfTime;

		public LARGE_INTEGER PerfFreq;
	}
}
