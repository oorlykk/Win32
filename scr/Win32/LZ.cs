using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Win32
{
	public abstract class LZ
	{
		[DllImport("lz32")]
		public static extern int CopyLZFile(int n1, int n2);

		[DllImport("lz32")]
		public static extern int LZStart();

		[DllImport("lz32")]
		public static extern void LZDone();

		[DllImport("lz32")]
		public static extern int GetExpandedName(string lpszSource, StringBuilder lpszBuffer);

		[DllImport("lz32")]
		public static extern int LZCopy(IntPtr hfSource, IntPtr hfDest);

		[DllImport("lz32")]
		public static extern int LZInit(IntPtr hfSrc);

		[DllImport("lz32")]
		public static extern int LZOpenFile(string lpszFile, ref OFSTRUCT lpOf, int style);

		[DllImport("lz32")]
		public static extern int LZRead(IntPtr hfFile, string lpvBuf, int cbread);

		[DllImport("lz32")]
		public static extern int LZSeek(IntPtr hfFile, int lOffset, int nOrigin);

		[DllImport("lz32")]
		public static extern void LZClose(IntPtr hfFile);
	}
}
