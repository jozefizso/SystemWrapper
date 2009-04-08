using System.IO;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.MemoryStream"/> class.
    /// </summary>
    public class MemoryStreamWrap : Stream, IMemoryStreamWrap
    {
        /// <summary>
        /// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized to zero. 
        /// </summary>
        public MemoryStreamWrap()
        {
            MemoryStreamInstance = new MemoryStream();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.MemoryStreamWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="memoryStream">A <see cref="T:System.IO.MemoryStream"/> object.</param>
        public MemoryStreamWrap(MemoryStream memoryStream)
        {
            MemoryStreamInstance = memoryStream;
        }

        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified byte array. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create the current stream. </param>
        public MemoryStreamWrap(byte[] buffer)
        {
            MemoryStreamInstance = new MemoryStream(buffer);
        }

        /// <summary>
        /// Initializes a new instance of the MemoryStreamWrap class with an expandable capacity initialized as specified. 
        /// </summary>
        /// <param name="capacity"></param>
        public MemoryStreamWrap(int capacity)
        {
            MemoryStreamInstance = new MemoryStream(capacity);
        }

        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified byte array with the CanWrite property set as specified. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
        public MemoryStreamWrap(byte[] buffer, bool writable)
        {
            MemoryStreamInstance = new MemoryStream(buffer, writable);
        }

        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified region (index) of a byte array. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="index">The index into buffer at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes. </param>
        public MemoryStreamWrap(byte[] buffer, int index, int count)
        {
            MemoryStreamInstance = new MemoryStream(buffer, index, count);
        }

        /// <summary>
        /// Initializes a new non-resizable instance of the MemoryStreamWrap class based on the specified region of a byte array, with the CanWrite property set as specified. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="index">The index into buffer at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes. </param>
        /// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
        public MemoryStreamWrap(byte[] buffer, int index, int count, bool writable)
        {
            MemoryStreamInstance = new MemoryStream(buffer, index, count, writable);
        }

        /// <summary>
        /// Initializes a new instance of the MemoryStreamWrap class based on the specified region of a byte array, with the CanWrite property set as specified, and the ability to call GetBuffer set as specified. 
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
        /// <param name="index">The index into buffer at which the stream begins.</param>
        /// <param name="count">The length of the stream in bytes.</param>
        /// <param name="writable">The setting of the CanWrite property, which determines whether the stream supports writing. </param>
        /// <param name="publiclyVisible"> true to enable GetBuffer, which returns the unsigned byte array from which the stream was created; otherwise, false. </param>
        public MemoryStreamWrap(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
        {
            MemoryStreamInstance = new MemoryStream(buffer, index, count, writable);
        }

        public MemoryStream MemoryStreamInstance { get; private set; }

        /// <summary>
        /// Gets <see cref="T:System.IO.Stream"/> object.
        /// </summary>
        public Stream StreamInstance { get { return MemoryStreamInstance; } }

        public byte[] ToArray()
        {
            return MemoryStreamInstance.ToArray();
        }

        public override void Flush()
        {
            throw new System.NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new System.NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new System.NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new System.NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new System.NotImplementedException();
        }

        public override bool CanRead
        {
            get { throw new System.NotImplementedException(); }
        }

        public override bool CanSeek
        {
            get { throw new System.NotImplementedException(); }
        }

        public override bool CanWrite
        {
            get { throw new System.NotImplementedException(); }
        }

        public override long Length
        {
            get { throw new System.NotImplementedException(); }
        }

        public override long Position
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}
