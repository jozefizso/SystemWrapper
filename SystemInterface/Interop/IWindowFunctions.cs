using System;
using System.Collections.Generic;
using System.Linq;

namespace SystemInterface.Interop
{
    public interface IWindowFunctions
    {
        /// <summary>
        /// Retrieves the dimensions of the bounding rectangle of the specified window.
        /// The dimensions are given in screen coordinates that are relative to the upper-left corner of the screen.
        /// </summary>
        /// <param name="hwnd">A handle to the window.</param>
        /// <param name="lpRect">A pointer to a RECT structure that receives the screen coordinates of the upper-left and lower-right corners of the window.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
        /// </returns>
        /// <remarks>
        /// In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle are exclusive.
        /// In other words, the pixel at (right, bottom) lies immediately outside the rectangle.
        /// </remarks>
        bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
    }
}
