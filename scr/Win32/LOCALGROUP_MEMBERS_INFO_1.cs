using System;

namespace Win32
{
	public struct LOCALGROUP_MEMBERS_INFO_1
	{
		public int pSID;

		public g_netSID_NAME_USE eUsage;

		public int psName;
	}
}
