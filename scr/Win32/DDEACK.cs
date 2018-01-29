using System;

namespace Win32
{
	public struct DDEACK
	{
		public short bAppReturnCode;

		public short Reserved;

		public short fbusy;

		public short fack;
	}
}
