using System;

namespace Win32
{
	public struct SECURITY_DESCRIPTOR
	{
		public byte Revision;

		public byte Sbz1;

		public int Control;

		public int Owner;

		public int Group;

		public ACL Sacl;

		public ACL Dacl;
	}
}
