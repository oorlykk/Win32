using System;

namespace Win32
{
	public struct MOUSE_EVENT_RECORD
	{
		public COORD dwMousePosition;

		public int dwButtonState;

		public int dwControlKeyState;

		public int dwEventFlags;
	}
}
