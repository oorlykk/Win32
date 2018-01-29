using System;

namespace Win32
{
	public struct MCI_ANIM_UPDATE_PARMS
	{
		public int dwCallback;

		public RECT rc;

		public IntPtr hdc;
	}
}
