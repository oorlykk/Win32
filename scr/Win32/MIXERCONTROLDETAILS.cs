using System;

namespace Win32
{
	public struct MIXERCONTROLDETAILS
	{
		public int cbStruct;

		public int dwControlID;

		public int cChannels;

		public int item;

		public int cbDetails;

		public int paDetails;
	}
}
