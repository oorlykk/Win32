using System;

namespace Win32
{
	public struct MONHSZSTRUCT
	{
		public int cb;

		public int fsAction;

		public int dwTime;

		public IntPtr hsz;

		public IntPtr htask;

		public byte str;
	}
}
