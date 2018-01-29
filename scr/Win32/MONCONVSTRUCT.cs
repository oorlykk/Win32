using System;

namespace Win32
{
	public struct MONCONVSTRUCT
	{
		public int cb;

		public int fConnect;

		public int dwTime;

		public IntPtr htask;

		public IntPtr hszSvc;

		public IntPtr hszTopic;

		public IntPtr hConvClient;

		public IntPtr hConvServer;
	}
}
