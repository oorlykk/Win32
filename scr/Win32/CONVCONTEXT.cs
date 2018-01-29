using System;

namespace Win32
{
	public struct CONVCONTEXT
	{
		public int cb;

		public int wFlags;

		public int wCountryID;

		public int iCodePage;

		public int dwLangID;

		public int dwSecurity;

		public SECURITY_QUALITY_OF_SERVICE qos;
	}
}
