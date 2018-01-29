using System;

namespace Win32
{
	public struct ACCESS_ALLOWED_ACE
	{
		public ACE_HEADER Header;

		public int Mask;

		public int SidStart;
	}
}
