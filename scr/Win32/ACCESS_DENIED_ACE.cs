using System;

namespace Win32
{
	public struct ACCESS_DENIED_ACE
	{
		public ACE_HEADER Header;

		public int Mask;

		public int SidStart;
	}
}
