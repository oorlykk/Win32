using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public abstract class ComCtl
	{
		[DllImport("COMCTL32")]
		public static extern int ImageList_AddIcon(IntPtr himl, IntPtr hIcon);

		[DllImport("COMCTL32")]
		public static extern int ImageList_Create(int MinCx, int MinCy, int flags, int cInitial, int cGrow);

		[DllImport("COMCTL32")]
		public static extern int ImageList_Draw(IntPtr hIMAGELIST, int ImgIndex, IntPtr hdcDest, int xDest, int yDest, int lStyle);

		[DllImport("COMCTL32")]
		public static extern int ImageList_GetIcon(IntPtr hIMAGELIST, int ImgIndex, IntPtr hbmMask);

		[DllImport("COMCTL32")]
		public static extern int InitCommonControls();
	}
}
