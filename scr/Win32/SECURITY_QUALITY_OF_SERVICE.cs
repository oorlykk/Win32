using System;

namespace Win32
{
	public struct SECURITY_QUALITY_OF_SERVICE
	{
		public int Length;

		public short Impersonationlevel;

		public short ContextTrackingMode;

		public int EffectiveOnly;
	}
}
