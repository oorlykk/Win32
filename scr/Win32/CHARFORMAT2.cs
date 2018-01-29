using System;
using System.Runtime.InteropServices;

namespace Win32
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct CHARFORMAT2
	{
		public int cbSize;

		public uint dwMask;

		public uint dwEffects;

		public int yHeight;

		public int yOffset;

		public int crTextColor;

		public byte bCharSet;

		public byte bPitchAndFamily;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] szFaceName;

		public short wWeight;

		public short sSpacing;

		public int crBackColor;

		public int LCID;

		public uint dwReserved;

		public short sStyle;

		public short wKerning;

		public byte bUnderlineType;

		public byte bAnimation;

		public byte bRevAuthor;

		public byte bReserved1;
	}
}
