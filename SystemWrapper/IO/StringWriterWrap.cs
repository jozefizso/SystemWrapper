using System.IO;
using System.Threading.Tasks;
using SystemInterface.IO;

namespace SystemWrapper.IO
{
    public sealed class StringWriterWrap : IStringWriter
    {

        public StringWriterWrap(StringWriter instance)
        {
            this.Instance = instance;
        }

        public StringWriter Instance { get; private set; }

        TextWriter ITextWriter.Instance
        {
            get
            {
                return Instance;
            }
        }

        public void Flush()
        {
            Instance.Flush();
        }

        public async Task FlushAsync()
        {
            await Instance.FlushAsync().ConfigureAwait(false);
        }

        public void Write(long value)
        {
            Instance.Write(value);
        }

        public void Write(int value)
        {
            Instance.Write(value);
        }

        public void Write(ulong value)
        {
            Instance.Write(value);
        }

        public void Write(char value)
        {
            Instance.Write(value);
        }

        public void Write(char[] buffer)
        {
            Instance.Write(buffer);
        }

        public void Write(bool value)
        {
            Instance.Write(value);
        }

        public void Write(uint value)
        {
            Instance.Write(value);
        }

        public void Write(object value)
        {
            Instance.Write(value);
        }

        public void Write(double value)
        {
            Instance.Write(value);
        }

        public void Write(float value)
        {
            Instance.Write(value);
        }

        public void Write(decimal value)
        {
            Instance.Write(value);
        }

        public void Write(string value)
        {
            Instance.Write(value);
        }

        public void Write(string format, params object[] arg)
        {
            Instance.Write(format, arg);
        }

        public void Write(string format, object arg0)
        {
            Instance.Write(format, arg0);
        }

        public void Write(char[] buffer, int index, int count)
        {
            Instance.Write(buffer, index, count);
        }

        public void Write(string format, object arg0, object arg1)
        {
            Instance.Write(format, arg0, arg1);
        }

        public void Write(string format, object arg0, object arg1, object arg2)
        {
            Instance.Write(format, arg0, arg1, arg2);
        }

        public async Task WriteAsync(string value)
        {
            await Instance.WriteAsync(value).ConfigureAwait(false);
        }

        public async Task WriteAsync(char[] buffer)
        {
            await Instance.WriteAsync(buffer).ConfigureAwait(false);
        }

        public async Task WriteAsync(char value)
        {
            await Instance.WriteAsync(value).ConfigureAwait(false);
        }

        public async Task WriteAsync(char[] buffer, int index, int count)
        {
            await Instance.WriteAsync(buffer, index, count).ConfigureAwait(false);
        }

        public void WriteLine()
        {
            Instance.WriteLine();
        }

        public void WriteLine(long value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(ulong value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(char[] buffer)
        {
            Instance.WriteLine(buffer);
        }

        public void WriteLine(float value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(char value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(bool value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(uint value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(double value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(decimal value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(int value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(string value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(object value)
        {
            Instance.WriteLine(value);
        }

        public void WriteLine(string format, params object[] arg)
        {
            Instance.WriteLine(format, arg);
        }

        public void WriteLine(string format, object arg0)
        {
            Instance.WriteLine(format, arg0);
        }

        public void WriteLine(char[] buffer, int index, int count)
        {
            Instance.WriteLine(buffer, index, count);
        }

        public void WriteLine(string format, object arg0, object arg1)
        {
            Instance.WriteLine(format, arg0, arg1);
        }

        public void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            Instance.WriteLine(format, arg0, arg1, arg2);
        }

        public async Task WriteLineAsync()
        {
            await Instance.WriteLineAsync().ConfigureAwait(false);
        }

        public async Task WriteLineAsync(char[] buffer)
        {
            await Instance.WriteLineAsync(buffer).ConfigureAwait(false);
        }

        public async Task WriteLineAsync(string value)
        {
            await Instance.WriteLineAsync(value).ConfigureAwait(false);
        }

        public async Task WriteLineAsync(char value)
        {
            await Instance.WriteLineAsync(value).ConfigureAwait(false);
        }

        public async Task WriteLineAsync(char[] buffer, int index, int count)
        {
            await Instance.WriteLineAsync(buffer, index, count).ConfigureAwait(false);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Instance.Dispose();
                }
                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
