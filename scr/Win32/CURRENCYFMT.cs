using System;

namespace Win32
{
	public struct CURRENCYFMT
	{
		public int NumDigits;

		public int LeadingZero;

		public int Grouping;

		public string lpDecimalSep;

		public string lpThousandSep;

		public int NegativeOrder;

		public int PositiveOrder;

		public string lpCurrencySymbol;
	}
}
