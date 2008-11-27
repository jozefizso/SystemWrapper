using System.IO;
using System.Text;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamReader"/> class.
    /// </summary>
    public class StreamReaderWrap : TextReader, IStreamReaderWrap
    {
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
            get { throw new System.NotImplementedException(); }
        }

        public Encoding CurrentEncoding
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool EndOfStream
        {
            get { throw new System.NotImplementedException(); }
        }

        public StreamReader StreamReaderInstance { get; private set; }

        public override void Close()
        {
            StreamReaderInstance.Close();
        }

        public void DiscardBufferedData()
        {
            StreamReaderInstance.DiscardBufferedData();
        }

        public override int Peek()
        {
            return StreamReaderInstance.Peek();
        }

        public override int Read()
        {
            return StreamReaderInstance.Read();
        }

        public override int Read(char[] buffer, int index, int count)
        {
            return StreamReaderInstance.Read(buffer, index, count);
        }

        public override string ReadLine()
        {
            return StreamReaderInstance.ReadLine();
        }

        public override string ReadToEnd()
        {
            return StreamReaderInstance.ReadToEnd();
        }
    }
}