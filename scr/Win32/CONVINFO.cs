using System;

namespace Win32
{
	public struct CONVINFO
	{
		public int cb;

		public IntPtr hUser;

		public IntPtr hConvPartner;

		public IntPtr hszSvcPartner;

		public IntPtr hszServiceReq;

		public IntPtr hszTopic;

		public IntPtr hszItem;

		public int wFmt;

		public int wType;

		public int wStatus;

		public int wConvst;

		public int wLastError;

		public IntPtr hConvList;

		public CONVCONTEXT ConvCtxt;

		public IntPtr hwnd;

		public IntPtr hwndPartner;
	}
}
