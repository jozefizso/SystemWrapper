using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SystemInterface.Interop;
using SystemWrapper.Interop;

using NUnit.Framework;

namespace SystemWrapper.Tests.Interop
{
    [TestFixture]
    public class WindowFunctionsTests
    {
        [Test]
        public void GetWindowRect_BasicWinFormsWindow_ReturnsWindowRectangle()
        {
            // Arrange
            var form = new Form();
            form.Top = 10;
            form.Left = 15;
            form.Width = 200;
            form.Height = 300;

            var formHwnd = form.Handle;
            var native = new WindowFunctions();

            // Act
            RECT actualRect;
            var result = native.GetWindowRect(formHwnd, out actualRect);

            // Assert
            Assert.IsTrue(result, "GetWindowRect should return true.");
            Assert.AreEqual(form.Top, actualRect.Top);
            Assert.AreEqual(form.Left, actualRect.Left);
            Assert.AreEqual(form.Left + form.Width, actualRect.Right);
            Assert.AreEqual(form.Top + form.Height, actualRect.Bottom);
        }

        [Test]
        public void GetWindowRect_ZeroWindowHandle_ReturnsFalse()
        {
            // Arrange
            var native = new WindowFunctions();

            // Act
            RECT actualRect;
            var result = native.GetWindowRect(IntPtr.Zero, out actualRect);

            // Assert
            Assert.IsFalse(result, "GetWindowRect should return false.");
        }
    }
}
