using System;

namespace Win32
{
	public struct GCP_RESULTS
	{
		public int lStructSize;

		public string lpOutString;

		public int lpOrder;

		public int lpDX;

		public int lpCaretPos;

		public string lpClass;

		public string lpGlyphs;

		public int nGlyphs;

		public int nMaxFit;
	}
}
