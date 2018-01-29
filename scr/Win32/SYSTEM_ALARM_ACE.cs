using System;

namespace Win32
{
	public struct SYSTEM_ALARM_ACE
	{
		public ACE_HEADER Header;

		public int Mask;

		public int SidStart;
	}
}
