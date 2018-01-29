using System;

namespace Win32
{
	public struct SERVICE_TABLE_ENTRY
	{
		public string lpServiceName;

		public int lpServiceProc;
	}
}
