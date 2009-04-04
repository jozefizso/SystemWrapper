using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using SystemWrapper.Microsoft.Win32.SafeHandles;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    public interface IFileStreamWrap : IStreamWrap
    {
        // Properties

        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        /// <value> true if the stream supports reading; false if the stream is closed or was opened with write-only access. </value>
        bool CanRead { get; }
        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking. 
        /// </summary>
        bool CanSeek { get; }
        /// <summary>
        /// Gets a value that determines whether the current stream can time out. 
        /// </summary>
        bool CanTimeout { get; }
        /// <summary>
        /// Gets a value indicating whether the current stream supports writing.
        /// </summary>
        bool CanWrite { get; }
        /// <summary>
        /// Gets <see cref="T:System.IO.FileStream"/> object.
        /// </summary>
        FileStream FileStreamInstance { get; }
        /// <summary>
        /// Gets a value indicating whether the FileStream was opened asynchronously or synchronously.
        /// </summary>
        bool IsAsync { get; }
        /// <summary>
        /// Gets the length in bytes of the stream.
        /// </summary>
        long Length { get; }
        /// <summary>
        /// Gets the name of the IFileStreamWrap that was passed to the constructor.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets or sets the current position of this stream.
        /// </summary>
        long Position { get; set; }
        /// <summary>
        /// Gets or sets a value, in miliseconds, that determines how long the stream will attempt to read before timing out.
        /// </summary>
        int ReadTimeout { get; set; }
        /// <summary>
        /// Gets a ISafeFileHandleWrap object that represents the operating system file handle for the file that the current FileStream object encapsulates. 
        /// </summary>
        ISafeFileHandleWrap SafeFileHandle { [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode), SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get; }
        /// <summary>
        /// Gets or sets a value, in miliseconds, that determines how long the stream will attempt to write before timing out.
        /// </summary>
        int WriteTimeout { get; set; }

         // Methods

        /// <summary>
        /// Begins an asynchronous read.
        /// </summary>
        /// <param name="array">The buffer to read data into.</param>
        /// <param name="offset">The byte offset in array at which to begin reading.</param>
        /// <param name="numBytes">The maximum number of bytes to read.</param>
        /// <param name="userCallback">The method to be called when the asynchronous read operation is completed.</param>
        /// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
        /// <returns>A user-provided object that distinguishes this particular asynchronous read request from other requests.</returns>
        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
        /// <summary>
        /// Begins an asynchronous write. 
        /// </summary>
        /// <param name="array">The buffer to read data into.</param>
        /// <param name="offset">The byte offset in array at which to begin reading.</param>
        /// <param name="numBytes">The maximum number of bytes to read.</param>
        /// <param name="userCallback">The method to be called when the asynchronous read operation is completed.</param>
        /// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
        /// <returns>An IAsyncResult that references the asynchronous write.</returns>
        [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
        IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
        /// <summary>
        /// Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream.
        /// </summary>
        void Close();
        /// <summary>
        /// Waits for the pending asynchronous read to complete. 
        /// </summary>
        /// <param name="asyncResult">The reference to the pending asynchronous request to wait for.</param>
        /// <returns>The number of bytes read from the stream, between 0 and the number of bytes you requested. Streams only return 0 at the end of the stream, otherwise, they should block until at least 1 byte is available.</returns>
        int EndRead(IAsyncResult asyncResult);
        /// <summary>
        /// Ends an asynchronous write, blocking until the I/O operation has completed. 
        /// </summary>
        /// <param name="asyncResult">The pending asynchronous I/O request. </param>
        void EndWrite(IAsyncResult asyncResult);
        /// <summary>
        /// Clears all buffers for this stream and causes any buffered data to be written to the file system.
        /// </summary>
        void Flush();
        /// <summary>
        /// Gets a IFileSecurityWrap object that encapsulates the access control list (ACL) entries for the file described by the current FileStream object. 
        /// </summary>
        /// <returns>A IFileSecurityWrap object that encapsulates the access control settings for the file described by the current FileStream object. </returns>
        IFileSecurityWrap GetAccessControl();
        /// <summary>
        /// Prevents other processes from changing the FileStream while permitting read access. 
        /// </summary>
        /// <param name="position">The beginning of the range to lock. The value of this parameter must be equal to or greater than zero (0). </param>
        /// <param name="length">The range to be locked. </param>
        void Lock(long position, long length);
        /// <summary>
        /// Reads a block of bytes from the stream and writes the data in a given buffer. 
        /// </summary>
        /// <param name="array">When this method returns, contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source. </param>
        /// <param name="offset">The byte offset in array at which the read bytes will be placed. </param>
        /// <param name="count">The maximum number of bytes to read. </param>
        /// <returns>The total number of bytes read into the buffer. This might be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached. </returns>
        int Read([In, Out] byte[] array, int offset, int count);
        /// <summary>
        /// Reads a byte from the file and advances the read position one byte. 
        /// </summary>
        /// <returns>The byte, cast to an Int32, or -1 if the end of the stream has been reached.</returns>
        int ReadByte();
        /// <summary>
        /// Sets the current position of this stream to the given value. 
        /// </summary>
        /// <param name="offset">The point relative to origin from which to begin seeking.</param>
        /// <param name="origin">Specifies the beginning, the end, or the current position as a reference point for origin, using a value of type SeekOrigin. </param>
        /// <returns></returns>
        long Seek(long offset, SeekOrigin origin);
        /// <summary>
        /// Applies access control list (ACL) entries described by a IFileSecurityWrap object to the file described by the current FileStream object. 
        /// </summary>
        /// <param name="fileSecurity">A IFileSecurityWrap object that describes an ACL entry to apply to the current file.</param>
        void SetAccessControl(IFileSecurityWrap fileSecurity);
        /// <summary>
        /// Sets the length of this stream to the given value.
        /// </summary>
        /// <param name="value">The new length of the stream.</param>
        void SetLength(long value);
        /// <summary>
        /// Returns a String that represents the current Object. 
        /// </summary>
        /// <returns>A String that represents the current Object. </returns>
        string ToString();
        /// <summary>
        /// Allows access by other processes to all or part of a file that was previously locked.
        /// </summary>
        /// <param name="position">The beginning of the range to unlock.</param>
        /// <param name="length">The range to be unlocked.</param>
        void Unlock(long position, long length);
        /// <summary>
        /// Writes a block of bytes to this stream using data from a buffer.
        /// </summary>
        /// <param name="array">The buffer containing data to write to the stream.</param>
        /// <param name="offset">The zero-based byte offset in array at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        void Write(byte[] array, int offset, int count);
        /// <summary>
        /// Writes a byte to the current position in the file stream.
        /// </summary>
        /// <param name="value">A byte to write to the stream.</param>
        void WriteByte(byte value);
    }
}