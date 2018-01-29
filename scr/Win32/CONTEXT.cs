using System;
using System.Runtime.InteropServices;

namespace Win32
{
	public struct CONTEXT
	{
		public double FltF0;

		public double FltF1;

		public double FltF2;

		public double FltF3;

		public double FltF4;

		public double FltF5;

		public double FltF6;

		public double FltF7;

		public double FltF8;

		public double FltF9;

		public double FltF10;

		public double FltF11;

		public double FltF12;

		public double FltF13;

		public double FltF14;

		public double FltF15;

		public double FltF16;

		public double FltF17;

		public double FltF18;

		public double FltF19;

		public double FltF20;

		public double FltF21;

		public double FltF22;

		public double FltF23;

		public double FltF24;

		public double FltF25;

		public double FltF26;

		public double FltF27;

		public double FltF28;

		public double FltF29;

		public double FltF30;

		public double FltF31;

		public double IntV0;

		public double IntT0;

		public double IntT1;

		public double IntT2;

		public double IntT3;

		public double IntT4;

		public double IntT5;

		public double IntT6;

		public double IntT7;

		public double IntS0;

		public double IntS1;

		public double IntS2;

		public double IntS3;

		public double IntS4;

		public double IntS5;

		public double IntFp;

		public double IntA0;

		public double IntA1;

		public double IntA2;

		public double IntA3;

		public double IntA4;

		public double IntA5;

		public double IntT8;

		public double IntT9;

		public double IntT10;

		public double IntT11;

		public double IntRa;

		public double IntT12;

		public double IntAt;

		public double IntGp;

		public double IntSp;

		public double IntZero;

		public double Fpcr;

		public double SoftFpcr;

		public double Fir;

		public int Psr;

		public int ContextFlags;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public int[] Fill;
	}
}
