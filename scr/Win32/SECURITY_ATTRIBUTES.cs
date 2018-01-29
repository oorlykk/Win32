using System;

namespace Win32
{
	public struct SECURITY_ATTRIBUTES
	{
		public int nLength;

		public int lpSecurityDescriptor;

		public int bInheritHandle;
	}
}
