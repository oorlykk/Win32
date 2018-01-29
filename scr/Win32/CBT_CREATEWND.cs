using System;

namespace Win32
{
	public struct CBT_CREATEWND
	{
		public CREATESTRUCT lpcs;

		public IntPtr hwndInsertAfter;
	}
}
