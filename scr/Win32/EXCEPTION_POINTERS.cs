using System;

namespace Win32
{
	public struct EXCEPTION_POINTERS
	{
		public EXCEPTION_RECORD pExceptionRecord;

		public CONTEXT ContextRecord;
	}
}
