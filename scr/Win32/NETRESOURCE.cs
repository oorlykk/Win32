using System;

namespace Win32
{
	public struct NETRESOURCE
	{
		public int dwScope;

		public int dwType;

		public int dwDisplayType;

		public int dwUsage;

		public string lpLocalName;

		public string lpRemoteName;

		public string lpComment;

		public string lpProvider;
	}
}
