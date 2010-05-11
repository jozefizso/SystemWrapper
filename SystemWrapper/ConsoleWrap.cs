using System;
using System.IO;

namespace SystemWrapper
{
    /// <summary>
    /// Wrapper for <see cref="System.Console"/> class.
    /// </summary>
    public class ConsoleWrap : IConsoleWrap
    {
        /// <inheritdoc />
        public ConsoleColor ForegroundColor
        {
            get { return Console.ForegroundColor; }
            set { Console.ForegroundColor = value; }
        }

        /// <inheritdoc />
        public TextWriter Out
        {
            get { return Console.Out; }
        }

        /// <inheritdoc />
        public void ResetColor()
        {
            Console.ResetColor();
        }

        /// <inheritdoc />
        public void SetOut(TextWriter newOut)
        {
            Console.SetOut(newOut);
        }

        /// <inheritdoc />
        public void Write(char value)
        {
            Console.Write(value);
        }

        /// <inheritdoc />
        public void Write(string value)
        {
            Console.Write(value);
        }

        /// <inheritdoc />
        public void WriteLine()
        {
            Console.WriteLine();
        }

        /// <inheritdoc />
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}