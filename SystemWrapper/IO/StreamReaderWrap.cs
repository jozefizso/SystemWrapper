using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamReader"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class StreamReaderWrap : IStreamReaderWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.StreamReaderWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="textReader">A <see cref="T:System.IO.TextReader"/> object.</param>
        public StreamReaderWrap(TextReader textReader)
        {
            StreamReaderInstance = textReader as StreamReader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.StreamReaderWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="streamReader">A <see cref="T:System.IO.StreamReader"/> object.</param>
        public StreamReaderWrap(StreamReader streamReader)
        {
            StreamReaderInstance = streamReader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.IO.StreamReader"/> class for the specified stream.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        public StreamReaderWrap(Stream stream)
        {
            StreamReaderInstance = new StreamReader(stream);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.IO.StreamReader"/> class for the specified stream.
        /// </summary>
        /// <param name="stream">The stream wrapper to write to.</param>
        public StreamReaderWrap(IStreamWrap stream)
        {
            StreamReaderInstance = new StreamReader(stream.StreamInstance);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified file name.
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        public StreamReaderWrap(string path)
        {
            StreamReaderInstance = new StreamReader(path);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified stream, with the specified byte order mark detection option.
        /// </summary>
        /// <param name="stream">The stream to be read. </param>
        /// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
        public StreamReaderWrap(Stream stream, bool detectEncodingFromByteOrderMarks)
        {
            StreamReaderInstance = new StreamReader(stream, detectEncodingFromByteOrderMarks);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified stream, with the specified character encoding.
        /// </summary>
        /// <param name="stream">The stream to be read.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public StreamReaderWrap(Stream stream, Encoding encoding)
        {
            StreamReaderInstance = new StreamReader(stream, encoding);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified file name, with the specified byte order mark detection option.
        /// </summary>
        /// <param name="path">The complete file path to be read. </param>
        /// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
        public StreamReaderWrap(string path, bool detectEncodingFromByteOrderMarks)
        {
            StreamReaderInstance = new StreamReader(path, detectEncodingFromByteOrderMarks);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified file name, with the specified character encoding.
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public StreamReaderWrap(string path, Encoding encoding)
        {
            StreamReaderInstance = new StreamReader(path, encoding);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified stream, with the specified character encoding and byte order mark detection option.
        /// </summary>
        /// <param name="stream">The stream to be read. </param>
        /// <param name="encoding">The character encoding to use. </param>
        /// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
        public StreamReaderWrap(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            StreamReaderInstance = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified file name, with the specified character encoding and byte order mark detection option. 
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        /// <param name="encoding">The character encoding to use. </param>
        /// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
        public StreamReaderWrap(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
        {
            StreamReaderInstance = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified stream, with the specified character encoding and byte order mark detection option, and buffer size.
        /// </summary>
        /// <param name="stream">The stream to be read. </param>
        /// <param name="encoding">The character encoding to use. </param>
        /// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
        /// <param name="bufferSize">The minimum buffer size. </param>
        public StreamReaderWrap(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            StreamReaderInstance = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }

        /// <summary>
        /// Initializes a new instance of the StreamReader class for the specified file name, with the specified character encoding and byte order mark detection option. 
        /// </summary>
        /// <param name="path">The complete file path to be read.</param>
        /// <param name="encoding">The character encoding to use. </param>
        /// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file.</param>
        /// <param name="bufferSize">The minimum buffer size, in number of 16-bit characters.</param>
        public StreamReaderWrap(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
        {
            StreamReaderInstance = new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize);
        }

        public Stream BaseStream
        {
            get { return StreamReaderInstance.BaseStream; }
        }

        public Encoding CurrentEncoding
        {
            get { return StreamReaderInstance.CurrentEncoding; }
        }

        public bool EndOfStream
        {
            get { return StreamReaderInstance.EndOfStream; }
        }

        public StreamReader StreamReaderInstance { get; private set; }

        public TextReader TextReaderInstance{ get{ return StreamReaderInstance; } }

        public void Close()
        {
            StreamReaderInstance.Close();
        }

        public void DiscardBufferedData()
        {
            StreamReaderInstance.DiscardBufferedData();
        }

        /// <summary>
        /// Returns the next available character but does not consume it. 
        /// </summary>
        /// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the stream does not support seeking.</returns>
        public int Peek()
        {
            return StreamReaderInstance.Peek();
        }

        public int Read()
        {
            return StreamReaderInstance.Read();
        }

        /// <summary>
        /// Reads a maximum of count characters from the current stream into buffer, beginning at index. 
        /// </summary>
        /// <param name="buffer">When this method returns, contains the specified character array with the values between index and (index + count - 1) replaced by the characters read from the current source.</param>
        /// <param name="index">The index of buffer at which to begin writing.</param>
        /// <param name="count">The maximum number of characters to read. </param>
        /// <returns>The number of characters that have been read, or 0 if at the end of the stream and no data was read. The number will be less than or equal to the count parameter, depending on whether the data is available within the stream.</returns>
        public int Read(char[] buffer, int index, int count)
        {
            return StreamReaderInstance.Read(buffer, index, count);
        }

        public int ReadBlock(char[] buffer, int index, int count)
        {
            return StreamReaderInstance.ReadBlock(buffer, index, count);
        }

        public string ReadLine()
        {
            return StreamReaderInstance.ReadLine();
        }

        /// <summary>
        /// Reads the stream from the current position to the end of the stream.
        /// </summary>
        /// <returns>The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns the empty string("").</returns>
        public string ReadToEnd()
        {
            return StreamReaderInstance.ReadToEnd();
        }

        public ITextReaderWrap Synchronized(ITextReaderWrap reader)
        {
            return new StreamReaderWrap(TextReader.Synchronized(reader.TextReaderInstance));
        }

        public void Dispose()
        {
            StreamReaderInstance.Dispose();
        }
    }
}