using System;

namespace Win32
{
	public struct EXCEPTION_DEBUG_INFO
	{
		public EXCEPTION_RECORD pExceptionRecord;

		public int dwFirstChance;
	}
}
