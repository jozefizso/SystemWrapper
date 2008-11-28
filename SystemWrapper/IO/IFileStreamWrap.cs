using System;
using System.IO;
using System.Security.Permissions;
using SystemWrapper.Microsoft.Win32.SafeHandles;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    public interface IFileStreamWrap
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

        /*

                    public override int EndRead(IAsyncResult asyncResult);
                    public override void EndWrite(IAsyncResult asyncResult);
                    public override void Flush();
                    public FileSecurity GetAccessControl();
                    public virtual void Lock(long position, long length);
                    public override int Read([In, Out] byte[] array, int offset, int count);
                    public override int ReadByte();
                    public override long Seek(long offset, SeekOrigin origin);
                    public void SetAccessControl(FileSecurity fileSecurity);
                    public override void SetLength(long value);
                    public virtual void Unlock(long position, long length);
                    public override void Write(byte[] array, int offset, int count);
                    public override void WriteByte(byte value);
        */
    }
}