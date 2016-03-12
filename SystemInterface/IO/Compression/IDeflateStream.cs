using System.IO.Compression;

namespace SystemInterface.IO.Compression
{
    /// <summary>
    /// Description of IDeflateStreamWrap.
    /// </summary>
    public interface IDeflateStream
    {
        /// <summary>
        /// Initializes a new instance of the DeflateStream class using the specified stream and CompressionMode value, and a value that specifies whether to leave the stream open.
        /// </summary>
        /// <param name="stream">The stream to compress or decompress.</param>
        /// <param name="mode">One of the CompressionMode values that indicates the action to take.</param>
        void Initialize(IStream stream, CompressionMode mode);

        /// <summary>
        /// Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream.
        /// </summary>
        void Close();

        /// <summary>
        /// Flushes the contents of the internal buffer of the current stream object to the underlying stream.
        /// </summary>
        void Flush();

        /// <summary>
        /// Reads a number of decompressed bytes into the specified byte array.
        /// </summary>
        /// <param name="array">The array to store decompressed bytes.</param>
        /// <param name="offset">The byte offset in array at which the read bytes will be placed.</param>
        /// <param name="count">The maximum number of decompressed bytes to read.</param>
        /// <returns>The number of bytes that were read into the byte array.</returns>
        int Read(byte[] array, int offset, int count);

        /// <summary>
        /// Writes compressed bytes to the underlying stream from the specified byte array.
        /// </summary>
        /// <param name="array">The buffer that contains the data to compress.</param>
        /// <param name="offset">The byte offset in array at which the compressed bytes will be placed.</param>
        /// <param name="count">The maximum number of compressed bytes to write.</param>
        void Write(byte[] array, int offset, int count);

        /// <summary>
        /// DeflateStream object.
        /// </summary>
        DeflateStream DeflateStreamInstance { get; }
    }
}
