using System;

namespace Win32
{
	public struct ACL_SIZE_INFORMATION
	{
		public int AceCount;

		public int AclBytesInUse;

		public int AclBytesFree;
	}
}
