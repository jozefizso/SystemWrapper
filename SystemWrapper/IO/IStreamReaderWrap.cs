using System.IO;
using System.Text;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamReader"/> class.
    /// </summary>
    public interface IStreamReaderWrap : ITextReaderWrap
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
        /// Allows a IStreamReaderWrap object to discard its current data. 
        /// </summary>
        void DiscardBufferedData();
    }
}