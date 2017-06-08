using System;
using System.IO;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;

namespace SystemInterface.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamWriter"/> class.
    /// </summary>
    [CLSCompliant(false)]
    public interface IStreamWriter : ITextWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.IO.StreamWriterWrap"/> class on the specified path.
        /// </summary>
        /// <param name="streamWriter">A <see cref="T:System.IO.StreamWriter"/> object.</param>
        void Initialize(StreamWriter streamWriter);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.IO.StreamWriterWrap"/> class for the specified stream, using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        void Initialize(Stream stream);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.IO.StreamWriterWrap"/> class for the specified stream, using UTF-8 encoding and the default buffer size.
        /// </summary>
        /// <param name="path">The complete file path to write to. path can be a file name.</param>
        void Initialize(string path);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.IO.StreamWriterWrap"/> class for the specified stream, using the specified encoding and the default buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        void Initialize(Stream stream, Encoding encoding);

        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the default encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        void Initialize(string path, bool append);

        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified stream, using the specified encoding and buffer size.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">Sets the buffer size.</param>
        void Initialize(Stream stream, Encoding encoding, int bufferSize);

        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the specified encoding and default buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        /// <param name="encoding">The character encoding to use.</param>
        void Initialize(string path, bool append, Encoding encoding);

        /// <summary>
        /// Initializes a new instance of the StreamWriter class for the specified file on the specified path, using the specified encoding and buffer size. If the file exists, it can be either overwritten or appended to. If the file does not exist, this constructor creates a new file.
        /// </summary>
        /// <param name="path">The complete file path to write to.</param>
        /// <param name="append">Determines whether data is to be appended to the file. If the file exists and append is false, the file is overwritten. If the file exists and append is true, the data is appended to the file. Otherwise, a new file is created.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <param name="bufferSize">Sets the buffer size.</param>
        void Initialize(string path, bool append, Encoding encoding, int bufferSize);

        // Properties

        /// <summary>
        /// Gets or sets a value indicating whether the IStreamWriterWrap will flush its buffer to the underlying stream after every call to IStreamWriterWrap.Write.
        /// </summary>
        bool AutoFlush { get; set; }

        /// <summary>
        /// Gets the underlying stream that interfaces with a backing store.
        /// </summary>
        Stream BaseStream { get; }

        /// <summary>
        /// Gets the Encoding in which the output is written.
        /// </summary>
        Encoding Encoding { get; }

        /// <summary>
        /// Gets an object that controls formatting.
        /// </summary>
        IFormatProvider FormatProvider { get; }

        /// <summary>
        /// Gets or sets the line terminator string used by the current TextWriter.
        /// </summary>
        string NewLine { get; set; }

        /// <summary>
        /// Gets <see cref="T:System.IO.StreamWriter"/> object.
        /// </summary>
        StreamWriter StreamWriterInstance { get; }

        // Methods

        /// <summary>
        /// Implements a TextWriter for writing characters to a stream in a particular encoding.
        /// </summary>
        void Close();

        /// <summary>
        /// Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.
        /// </summary>
        /// <param name="requestedType">The Type of the object that the new ObjRef will reference.</param>
        /// <returns>Information required to generate a proxy.</returns>
        [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
        ObjRef CreateObjRef(Type requestedType);
    }
}
