using System;

namespace Win32
{
	public struct ENUM_SERVICE_STATUS
	{
		public string lpServiceName;

		public string lpDisplayName;

		public SERVICE_STATUS ServiceStatus;
	}
}
