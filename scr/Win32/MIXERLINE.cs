using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct MIXERLINE
	{
		public int cbStruct;

		public int dwDestination;

		public int dwSource;

		public int dwLineID;

		public int fdwLine;

		public int dwUser;

		public int dwComponentType;

		public int cChannels;

		public int cConnections;

		public int cControls;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string szShortName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string szName;

		public TARGET tTarget;
	}
}
