using System;

namespace Win32
{
	public struct ACE_HEADER
	{
		public byte AceType;

		public byte AceFlags;

		public int AceSize;
	}
}
