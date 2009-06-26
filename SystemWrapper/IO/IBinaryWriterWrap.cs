using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
    /// Wrapper for <see cref="T:System.IO.BinaryWriter"/> class.
	/// </summary>
	public interface IBinaryWriterWrap : IDisposable
	{
        // Properties

        /// <summary>
        /// Gets the underlying stream of the BinaryWriter.
        /// </summary>
        Stream BaseStream { get; }
        /// <summary>
        /// Gets <see cref="T:System.IO.BinaryWriter"/> object.
        /// </summary>
        BinaryWriter BinaryWriterInstance { get; }

        // Methods

        /// <summary>
        /// Closes the current BinaryWriter and the underlying stream. 
        /// </summary>
        void Close();
        /// <summary>
        /// Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.
        /// </summary>
        void Flush();
        /// <summary>
        /// Sets the position within the current stream.
        /// </summary>
        /// <param name="offset">A byte offset relative to origin.</param>
        /// <param name="origin">A field of SeekOrigin indicating the reference point from which the new position is to be obtained.</param>
        /// <returns>The position with the current stream.</returns>
        long Seek(int offset, SeekOrigin origin);
        /// <summary>
        /// Writes a one-byte Boolean value to the current stream, with 0 representing false and 1 representing true.
        /// </summary>
        /// <param name="value">The Boolean value to write (0 or 1).</param>
        void Write(bool value);
        /// <summary>
        /// Writes an unsigned byte to the current stream and advances the stream position by one byte.
        /// </summary>
        /// <param name="value">The unsigned byte to write.</param>
        void Write(byte value);
        /// <summary>
        /// Writes a byte array to the underlying stream. 
        /// </summary>
        /// <param name="buffer">A byte array containing the data to write. </param>
        void Write(byte[] buffer);
        /// <summary>
        /// Writes a Unicode character to the current stream and advances the current position of the stream in accordance with the Encoding used and the specific characters being written to the stream.
        /// </summary>
        /// <param name="ch">The non-surrogate, Unicode character to write. </param>
        void Write(char ch);
        /// <summary>
        /// Writes a character array to the current stream and advances the current position of the stream in accordance with the Encoding used and the specific characters being written to the stream.
        /// </summary>
        /// <param name="chars">A character array containing the data to write.</param>
        void Write(char[] chars);
        /// <summary>
        /// Writes a decimal value to the current stream and advances the stream position by sixteen bytes.
        /// </summary>
        /// <param name="value">The decimal value to write.</param>
        void Write(decimal value);
        /// <summary>
        /// Writes an eight-byte floating-point value to the current stream and advances the stream position by eight bytes.
        /// </summary>
        /// <param name="value">The eight-byte floating-point value to write.</param>
        void Write(double value);
        /// <summary>
        /// Writes a two-byte signed integer to the current stream and advances the stream position by two bytes.
        /// </summary>
        /// <param name="value">The two-byte signed integer to write.</param>
        void Write(short value);
        /// <summary>
        /// Writes a four-byte signed integer to the current stream and advances the stream position by four bytes. 
        /// </summary>
        /// <param name="value">The four-byte signed integer to write.</param>
        void Write(int value);
        /// <summary>
        /// Writes an eight-byte signed integer to the current stream and advances the stream position by eight bytes.
        /// </summary>
        /// <param name="value">The eight-byte signed integer to write.</param>
        void Write(long value);
        /// <summary>
        /// Writes a signed byte to the current stream and advances the stream position by one byte.
        /// </summary>
        /// <param name="value">The signed byte to write.</param>
        void Write(sbyte value);
        /// <summary>
        /// Writes a four-byte floating-point value to the current stream and advances the stream position by four bytes.
        /// </summary>
        /// <param name="value">The four-byte floating-point value to write.</param>
        void Write(float value);
        /// <summary>
        /// Writes a length-prefixed string to this stream in the current encoding of the BinaryWriter, and advances the current position of the stream in accordance with the encoding used and the specific characters being written to the stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        void Write(string value);
        /// <summary>
        /// Writes a two-byte unsigned integer to the current stream and advances the stream position by two bytes.
        /// </summary>
        /// <param name="value">The two-byte unsigned integer to write.</param>
        void Write(ushort value);
        /// <summary>
        /// Writes a four-byte unsigned integer to the current stream and advances the stream position by four bytes.
        /// </summary>
        /// <param name="value">The four-byte unsigned integer to write.</param>
        void Write(uint value);
        /// <summary>
        /// Writes an eight-byte unsigned integer to the current stream and advances the stream position by eight bytes.
        /// </summary>
        /// <param name="value">The eight-byte unsigned integer to write.</param>
        void Write(ulong value);
        /// <summary>
        /// Writes a region of a byte array to the current stream.
        /// </summary>
        /// <param name="buffer">A byte array containing the data to write.</param>
        /// <param name="index">The starting point in buffer at which to begin writing.</param>
        /// <param name="count">The number of bytes to write.</param>
        void Write(byte[] buffer, int index, int count);
        /// <summary>
        /// Writes a section of a character array to the current stream, and advances the current position of the stream in accordance with the Encoding used and perhaps the specific characters being written to the stream.
        /// </summary>
        /// <param name="chars">A character array containing the data to write.</param>
        /// <param name="index">The starting point in buffer at which to begin writing.</param>
        /// <param name="count">The number of bytes to write.</param>
        void Write(char[] chars, int index, int count);
	}
}
