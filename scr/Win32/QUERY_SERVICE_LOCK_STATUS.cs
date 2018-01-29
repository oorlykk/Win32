using System;

namespace Win32
{
	public struct QUERY_SERVICE_LOCK_STATUS
	{
		public int fIsLocked;

		public string lpLockOwner;

		public int dwLockDuration;
	}
}
