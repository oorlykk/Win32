using System;

namespace Win32
{
	public struct DELETEITEMSTRUCT
	{
		public int CtlType;

		public int CtlID;

		public int itemID;

		public IntPtr hwndItem;

		public int itemData;
	}
}
