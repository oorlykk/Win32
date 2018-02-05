using System;
using System.Runtime.InteropServices;

namespace Win32
{
    //[StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct LASTINPUTINFO
    {
        public int cbSize;

        public int dwTime;
    }
}
