using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using SystemInterface.Interop;

namespace SystemWrapper.Interop
{
    public class WindowFunctions : IWindowFunctions
    {
        private const string USER32_DLL = "user32.dll";

        public bool GetWindowRect(IntPtr hwnd, out RECT lpRect)
        {
            return GetWindowRectNative(hwnd, out lpRect);
        }

        [DllImport(USER32_DLL, EntryPoint = "GetWindowRect", SetLastError = true)]
        private static extern bool GetWindowRectNative(IntPtr hwnd, out RECT lpRect);
    }
}
