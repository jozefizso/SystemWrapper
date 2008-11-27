using System;
using System.IO;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamWriter"/> class.
    /// </summary>
    public interface IStreamWriterWrap
    {
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
        /// <summary>
        /// Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.
        /// </summary>
        void Flush();
        /// <summary>
        /// Writes a character to the stream.
        /// </summary>
        /// <param name="value">The character to write to the text stream.</param>
        void Write(char value);
        /// <summary>
        /// Writes a character array to the stream.
        /// </summary>
        /// <param name="buffer">A character array containing the data to write. If buffer is nullNothingnullptra null reference (Nothing in Visual Basic), nothing is written.</param>
        void Write(char[] buffer);
        /// <summary>
        /// Writes a string to the stream.
        /// </summary>
        /// <param name="value">The string to write to the stream. If value is null, nothing is written.</param>
        void Write(string value);
        /// <summary>
        /// Writes the text representation of a Boolean value to the text stream.
        /// </summary>
        /// <param name="value">The Boolean to write.</param>
        void Write(bool value);
        /// <summary>
        /// Writes the text representation of a decimal value to the text stream. 
        /// </summary>
        /// <param name="value">The decimal value to write.</param>
        void Write(decimal value);
        /// <summary>
        /// Writes the text representation of an 8-byte floating-point value to the text stream. 
        /// </summary>
        /// <param name="value">The 8-byte floating-point value to write.</param>
        void Write(double value);
        /// <summary>
        /// Writes the text representation of a 4-byte signed integer to the text stream.
        /// </summary>
        /// <param name="value">The 4-byte signed integer to write.</param>
        void Write(int value);
        /// <summary>
        /// Writes the text representation of an 8-byte signed integer to the text stream. 
        /// </summary>
        /// <param name="value">The 8-byte signed integer to write.</param>
        void Write(long value);
        /// <summary>
        /// Writes the text representation of an object to the text stream by calling ToString on that object. 
        /// </summary>
        /// <param name="value">The object to write. </param>
        void Write(Object value);
        /// <summary>
        /// Writes the text representation of a 4-byte floating-point value to the text stream. 
        /// </summary>
        /// <param name="value">The 4-byte floating-point value to write.</param>
        void Write(float value);
        /// <summary>
        /// Writes the text representation of a 4-byte unsigned integer to the text stream. 
        /// </summary>
        /// <param name="value">The 4-byte unsigned integer to write.</param>
        void Write(uint value);
        /// <summary>
        /// Writes the text representation of an 8-byte unsigned integer to the text stream.
        /// </summary>
        /// <param name="value">The 8-byte unsigned integer to write.</param>
        void Write(ulong value);
        /// <summary>
        /// Writes out a formatted string, using the same semantics as String.Format. 
        /// </summary>
        /// <param name="format">The formatting string. </param>
        /// <param name="arg0">An object to write into the formatted string.</param>
        void Write(string format, Object arg0);
        /// <summary>
        /// Writes out a formatted string, using the same semantics as String.Format. 
        /// </summary>
        /// <param name="format">The formatting string. </param>
        /// <param name="arg">The object array to write into the formatted string. </param>
        void Write(string format, Object[] arg);
        /// <summary>
        /// Writes a subarray of characters to the stream.
        /// </summary>
        /// <param name="buffer">A character array containing the data to write. </param>
        /// <param name="index">The index into buffer at which to begin writing.</param>
        /// <param name="count">The number of characters to read from buffer. </param>
        void Write(char[] buffer, int index, int count);
        /// <summary>
        /// Writes out a formatted string, using the same semantics as String.Format. 
        /// </summary>
        /// <param name="format">The formatting string. </param>
        /// <param name="arg0">An object to write into the formatted string.</param>
        /// <param name="arg1">An object to write into the formatted string.</param>
        void Write(string format, Object arg0, Object arg1);
        /// <summary>
        /// Writes out a formatted string, using the same semantics as String.Format. 
        /// </summary>
        /// <param name="format">The formatting string. </param>
        /// <param name="arg0">An object to write into the formatted string.</param>
        /// <param name="arg1">An object to write into the formatted string.</param>
        /// <param name="arg2">An object to write into the formatted string.</param>
        void Write(string format, Object arg0, Object arg1, Object arg2);
    }
}