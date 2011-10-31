using System;
using System.Threading;

namespace SystemWrapper.Threading
{
    /// <summary>
    /// Wrapper for <see cref="System.Threading.Thread"/> class.
    /// </summary>
    public class ThreadWrap : IThreadWrap
    {
        /// <inheritdoc />
        public void Sleep(int millisecondsTimeout)
        {
            Thread.Sleep(millisecondsTimeout);
        }

        /// <inheritdoc />
        public void Sleep(TimeSpan timeout)
        {
            Thread.Sleep(timeout);
        }
    }
}