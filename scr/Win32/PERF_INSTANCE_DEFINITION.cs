using System;

namespace Win32
{
	public struct PERF_INSTANCE_DEFINITION
	{
		public int ByteLength;

		public int ParentObjectTitleIndex;

		public int ParentObjectInstance;

		public int UniqueID;

		public int NameOffset;

		public int NameLength;
	}
}
