using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of ITextReaderWrap.
	/// </summary>
	public interface ITextReaderWrap
	{
		/// <summary>
        /// Closes the IStreamReaderWrap object and the underlying stream, and releases any system resources associated with the reader.
        /// </summary>
        void Close();
        
		/// <summary>
        /// Reads the next character from the input stream and advances the character position by one character. 
        /// </summary>
        /// <returns>The next character from the input stream represented as an Int32 object, or -1 if no more characters are available.</returns>
        int Read();
        
        /// <summary>
        /// Reads a line of characters from the current stream and returns the data as a string.
        /// </summary>
        /// <returns>The next line from the input stream, or nullNothingnullptra null reference (Nothing in Visual Basic) if the end of the input stream is reached.</returns>
        string ReadLine();
        
        TextReader TextReaderInstance{ get; }
		
        //TODO
	}
}
