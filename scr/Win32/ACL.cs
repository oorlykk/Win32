using System;

namespace Win32
{
	public struct ACL
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}
}
