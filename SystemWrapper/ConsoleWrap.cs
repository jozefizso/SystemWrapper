using System;
using System.IO;

namespace SystemWrapper
{
    /// <summary>
    /// Wrapper for <see cref="System.Console"/> class.
    /// </summary>
    public class ConsoleWrap : IConsoleWrap
    {
        public TextWriter Out
        {
            get { return Console.Out; }
        }

        public void SetOut(TextWriter newOut)
        {
            Console.SetOut(newOut);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}