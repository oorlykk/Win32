using System;

namespace Win32
{
	public struct SERVICE_STATUS
	{
		public int dwServiceType;

		public int dwCurrentState;

		public int dwControlsAccepted;

		public int dwWin32ExitCode;

		public int dwServiceSpecificExitCode;

		public int dwCheckPoint;

		public int dwWaitHint;
	}
}
