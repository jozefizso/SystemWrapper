using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SystemInterface.IO
{
    public interface ITextWriter : IDisposable
    {
        TextWriter Instance { get; }

        void Flush();
        //
        // Summary:
        //     Asynchronously clears all buffers for the current writer and causes any buffered
        //     data to be written to the underlying device.
        //
        // Returns:
        //     A task that represents the asynchronous flush operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task FlushAsync();
        //
        // Summary:
        //     Writes a string to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The string to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(string value);
        //
        // Summary:
        //     Writes the text representation of a decimal value to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The decimal value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(decimal value);
        //
        // Summary:
        //     Writes the text representation of an 8-byte floating-point value to the text
        //     string or stream.
        //
        // Parameters:
        //   value:
        //     The 8-byte floating-point value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(double value);
        //
        // Summary:
        //     Writes the text representation of a 4-byte floating-point value to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The 4-byte floating-point value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(float value);
        //
        // Summary:
        //     Writes the text representation of an object to the text string or stream by calling
        //     the ToString method on that object.
        //
        // Parameters:
        //   value:
        //     The object to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(object value);
        //
        // Summary:
        //     Writes the text representation of an 8-byte signed integer to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The 8-byte signed integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(long value);
        //
        // Summary:
        //     Writes the text representation of a 4-byte unsigned integer to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The 4-byte unsigned integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        [CLSCompliant(false)]
        void Write(uint value);
        //
        // Summary:
        //     Writes the text representation of a 4-byte signed integer to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The 4-byte signed integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(int value);
        //
        // Summary:
        //     Writes the text representation of a Boolean value to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The Boolean value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(bool value);
        //
        // Summary:
        //     Writes the text representation of an 8-byte unsigned integer to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The 8-byte unsigned integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        [CLSCompliant(false)]
        void Write(ulong value);
        //
        // Summary:
        //     Writes a character array to the text string or stream.
        //
        // Parameters:
        //   buffer:
        //     The character array to write to the text stream.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(char[] buffer);
        //
        // Summary:
        //     Writes a character to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The character to write to the text stream.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(char value);
        //
        // Summary:
        //     Writes a formatted string to the text string or stream, using the same semantics
        //     as the System.String.Format(System.String,System.Object) method.
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg0:
        //     The object to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the number of objects to be
        //     formatted (which, for this method overload, is one).
        void Write(string format, object arg0);
        //
        // Summary:
        //     Writes a formatted string to the text string or stream, using the same semantics
        //     as the System.String.Format(System.String,System.Object[]) method.
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg:
        //     An object array that contains zero or more objects to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format or arg is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the length of the arg array.
        void Write(string format, params object[] arg);
        //
        // Summary:
        //     Writes a formatted string to the text string or stream, using the same semantics
        //     as the System.String.Format(System.String,System.Object,System.Object) method.
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg0:
        //     The first object to format and write.
        //
        //   arg1:
        //     The second object to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero) or greater than or equal to the number of objects to be
        //     formatted (which, for this method overload, is two).
        void Write(string format, object arg0, object arg1);
        //
        // Summary:
        //     Writes a subarray of characters to the text string or stream.
        //
        // Parameters:
        //   buffer:
        //     The character array to write data from.
        //
        //   index:
        //     The character position in the buffer at which to start retrieving data.
        //
        //   count:
        //     The number of characters to write.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The buffer length minus index is less than count.
        //
        //   T:System.ArgumentNullException:
        //     The buffer parameter is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index or count is negative.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void Write(char[] buffer, int index, int count);
        //
        // Summary:
        //     Writes a formatted string to the text string or stream, using the same semantics
        //     as the System.String.Format(System.String,System.Object,System.Object,System.Object)
        //     method.
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg0:
        //     The first object to format and write.
        //
        //   arg1:
        //     The second object to format and write.
        //
        //   arg2:
        //     The third object to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the number of objects to be
        //     formatted (which, for this method overload, is three).
        void Write(string format, object arg0, object arg1, object arg2);
        //
        // Summary:
        //     Writes a character to the text string or stream asynchronously.
        //
        // Parameters:
        //   value:
        //     The character to write to the text stream.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteAsync(char value);
        //
        // Summary:
        //     Writes a character array to the text string or stream asynchronously.
        //
        // Parameters:
        //   buffer:
        //     The character array to write to the text stream. If buffer is null, nothing is
        //     written.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteAsync(char[] buffer);
        //
        // Summary:
        //     Writes a string to the text string or stream asynchronously.
        //
        // Parameters:
        //   value:
        //     The string to write. If value is null, nothing is written to the text stream.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteAsync(string value);
        //
        // Summary:
        //     Writes a subarray of characters to the text string or stream asynchronously.
        //
        // Parameters:
        //   buffer:
        //     The character array to write data from.
        //
        //   index:
        //     The character position in the buffer at which to start retrieving data.
        //
        //   count:
        //     The number of characters to write.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     buffer is null.
        //
        //   T:System.ArgumentException:
        //     The index plus count is greater than the buffer length.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index or count is negative.
        //
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteAsync(char[] buffer, int index, int count);
        //
        // Summary:
        //     Writes a line terminator to the text string or stream.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine();
        //
        // Summary:
        //     Writes the text representation of an object by calling the ToString method on
        //     that object, followed by a line terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The object to write. If value is null, only the line terminator is written.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(object value);
        //
        // Summary:
        //     Writes a string followed by a line terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The string to write. If value is null, only the line terminator is written.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(string value);
        //
        // Summary:
        //     Writes the text representation of a decimal value followed by a line terminator
        //     to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The decimal value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(decimal value);
        //
        // Summary:
        //     Writes the text representation of a 4-byte signed integer followed by a line
        //     terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The 4-byte signed integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(int value);
        //
        // Summary:
        //     Writes the text representation of a 4-byte floating-point value followed by a
        //     line terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The 4-byte floating-point value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(float value);
        //
        // Summary:
        //     Writes a character followed by a line terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The character to write to the text stream.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(char value);
        //
        // Summary:
        //     Writes the text representation of a 8-byte floating-point value followed by a
        //     line terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The 8-byte floating-point value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(double value);
        //
        // Summary:
        //     Writes the text representation of a Boolean value followed by a line terminator
        //     to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The Boolean value to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(bool value);
        //
        // Summary:
        //     Writes the text representation of a 4-byte unsigned integer followed by a line
        //     terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The 4-byte unsigned integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        [CLSCompliant(false)]
        void WriteLine(uint value);
        //
        // Summary:
        //     Writes the text representation of an 8-byte signed integer followed by a line
        //     terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The 8-byte signed integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(long value);
        //
        // Summary:
        //     Writes an array of characters followed by a line terminator to the text string
        //     or stream.
        //
        // Parameters:
        //   buffer:
        //     The character array from which data is read.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(char[] buffer);
        //
        // Summary:
        //     Writes the text representation of an 8-byte unsigned integer followed by a line
        //     terminator to the text string or stream.
        //
        // Parameters:
        //   value:
        //     The 8-byte unsigned integer to write.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        [CLSCompliant(false)]
        void WriteLine(ulong value);
        //
        // Summary:
        //     Writes a formatted string and a new line to the text string or stream, using
        //     the same semantics as the System.String.Format(System.String,System.Object) method.
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg0:
        //     The object to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the number of objects to be
        //     formatted (which, for this method overload, is one).
        void WriteLine(string format, object arg0);
        //
        // Summary:
        //     Writes out a formatted string and a new line, using the same semantics as System.String.Format(System.String,System.Object).
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg:
        //     An object array that contains zero or more objects to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     A string or object is passed in as null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the length of the arg array.
        void WriteLine(string format, params object[] arg);
        //
        // Summary:
        //     Writes a formatted string and a new line to the text string or stream, using
        //     the same semantics as the System.String.Format(System.String,System.Object,System.Object)
        //     method.
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg0:
        //     The first object to format and write.
        //
        //   arg1:
        //     The second object to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the number of objects to be
        //     formatted (which, for this method overload, is two).
        void WriteLine(string format, object arg0, object arg1);
        //
        // Summary:
        //     Writes a subarray of characters followed by a line terminator to the text string
        //     or stream.
        //
        // Parameters:
        //   buffer:
        //     The character array from which data is read.
        //
        //   index:
        //     The character position in buffer at which to start reading data.
        //
        //   count:
        //     The maximum number of characters to write.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The buffer length minus index is less than count.
        //
        //   T:System.ArgumentNullException:
        //     The buffer parameter is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index or count is negative.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        void WriteLine(char[] buffer, int index, int count);
        //
        // Summary:
        //     Writes out a formatted string and a new line, using the same semantics as System.String.Format(System.String,System.Object).
        //
        // Parameters:
        //   format:
        //     A composite format string (see Remarks).
        //
        //   arg0:
        //     The first object to format and write.
        //
        //   arg1:
        //     The second object to format and write.
        //
        //   arg2:
        //     The third object to format and write.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     format is null.
        //
        //   T:System.ObjectDisposedException:
        //     The System.IO.TextWriter is closed.
        //
        //   T:System.IO.IOException:
        //     An I/O error occurs.
        //
        //   T:System.FormatException:
        //     format is not a valid composite format string.-or- The index of a format item
        //     is less than 0 (zero), or greater than or equal to the number of objects to be
        //     formatted (which, for this method overload, is three).
        void WriteLine(string format, object arg0, object arg1, object arg2);
        //
        // Summary:
        //     Writes a line terminator asynchronously to the text string or stream.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteLineAsync();
        //
        // Summary:
        //     Writes a character followed by a line terminator asynchronously to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The character to write to the text stream.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteLineAsync(char value);
        //
        // Summary:
        //     Writes a string followed by a line terminator asynchronously to the text string
        //     or stream.
        //
        // Parameters:
        //   value:
        //     The string to write. If the value is null, only a line terminator is written.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteLineAsync(string value);
        //
        // Summary:
        //     Writes an array of characters followed by a line terminator asynchronously to
        //     the text string or stream.
        //
        // Parameters:
        //   buffer:
        //     The character array to write to the text stream. If the character array is null,
        //     only the line terminator is written.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteLineAsync(char[] buffer);
        //
        // Summary:
        //     Writes a subarray of characters followed by a line terminator asynchronously
        //     to the text string or stream.
        //
        // Parameters:
        //   buffer:
        //     The character array to write data from.
        //
        //   index:
        //     The character position in the buffer at which to start retrieving data.
        //
        //   count:
        //     The number of characters to write.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     buffer is null.
        //
        //   T:System.ArgumentException:
        //     The index plus count is greater than the buffer length.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index or count is negative.
        //
        //   T:System.ObjectDisposedException:
        //     The text writer is disposed.
        //
        //   T:System.InvalidOperationException:
        //     The text writer is currently in use by a previous write operation.
        [ComVisible(false)]
        Task WriteLineAsync(char[] buffer, int index, int count);
    }
}
