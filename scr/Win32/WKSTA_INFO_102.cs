using System;

namespace Win32
{
	public struct WKSTA_INFO_102
	{
		public int wki102_platform_id;

		public int wki102_computername;

		public int wki102_langroup;

		public int wki102_ver_major;

		public int wki102_ver_minor;

		public int wki102_lanroot;

		public int wki102_logged_on_users;
	}
}
