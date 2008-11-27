using System.IO;
using System.Text;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamReader"/> class.
    /// </summary>
    public interface IStreamReaderWrap
    {
        // Properties

        /// <summary>
        /// Returns the underlying stream. 
        /// </summary>
        /// <value>The underlying stream.</value>
        Stream BaseStream { get; }
        /// <summary>
        /// Gets the current character encoding that the current IStreamReaderWrap object is using. 
        /// </summary>
        /// <value>The current character encoding used by the current reader. The value can be different after the first call to any Read method of IStreamReaderWrap, since encoding autodetection is not done until the first call to a Read method. </value>
        Encoding CurrentEncoding { get; }
        /// <summary>
        /// Gets a value that indicates whether the current stream position is at the end of the stream. 
        /// </summary>
        /// <value> true if the current stream position is at the end of the stream; otherwise false. </value>
        bool EndOfStream { get; }
        /// <summary>
        /// Gets <see cref="T:System.IO.StreamReader"/> object.
        /// </summary>
        StreamReader StreamReaderInstance { get; }


        // Methods

        /// <summary>
        /// Closes the IStreamReaderWrap object and the underlying stream, and releases any system resources associated with the reader.
        /// </summary>
        void Close();
        /// <summary>
        /// Allows a IStreamReaderWrap object to discard its current data. 
        /// </summary>
        void DiscardBufferedData();
        /// <summary>
        /// Returns the next available character but does not consume it. 
        /// </summary>
        /// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the stream does not support seeking.</returns>
        int Peek();
        /// <summary>
        /// Reads the next character from the input stream and advances the character position by one character. 
        /// </summary>
        /// <returns>The next character from the input stream represented as an Int32 object, or -1 if no more characters are available.</returns>
        int Read();
        /// <summary>
        /// Reads a maximum of count characters from the current stream into buffer, beginning at index. 
        /// </summary>
        /// <param name="buffer">When this method returns, contains the specified character array with the values between index and (index + count - 1) replaced by the characters read from the current source.</param>
        /// <param name="index">The index of buffer at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read. </param>
        /// <returns>The number of characters that have been read, or 0 if at the end of the stream and no data was read. The number will be less than or equal to the count parameter, depending on whether the data is available within the stream.</returns>
        int Read(char[] buffer, int index, int count);
        /// <summary>
        /// Reads a maximum of count characters from the current stream, and writes the data to buffer, beginning at index.
        /// </summary>
        /// <param name="buffer">When this method returns, this parameter contains the specified character array with the values between index and (index + count -1) replaced by the characters read from the current source.</param>
        /// <param name="index">The place in buffer at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read.</param>
        /// <returns></returns>
        int ReadBlock(char[] buffer, int index, int count);
        /// <summary>
        /// Reads a line of characters from the current stream and returns the data as a string.
        /// </summary>
        /// <returns>The next line from the input stream, or nullNothingnullptra null reference (Nothing in Visual Basic) if the end of the input stream is reached.</returns>
        string ReadLine();
        /// <summary>
        /// Reads the stream from the current position to the end of the stream.
        /// </summary>
        /// <returns>The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns the empty string("").</returns>
        string ReadToEnd();
    }
}