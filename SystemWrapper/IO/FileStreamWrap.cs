using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Permissions;
using SystemWrapper.Microsoft.Win32.SafeHandles;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class FileStreamWrap : Stream, IFileStreamWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileStream">A <see cref="T:System.IO.FileStream"/> object.</param>
        public FileStreamWrap(FileStream fileStream)
        {
            FileStreamInstance = fileStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class for the specified file handle, with the specified read/write permission. 
        /// </summary>
        /// <param name="handle">A file handle for the file that the current FileStream object will encapsulate. </param>
        /// <param name="access">A FileAccess constant that sets the CanRead and CanWrite properties of the FileStream object. </param>
        public FileStreamWrap(ISafeFileHandleWrap handle, FileAccess access)
        {
            FileStreamInstance = new FileStream(handle.SafeFileHandleInstance, access);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path and creation mode. 
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        public FileStreamWrap(string path, FileMode mode)
        {
            FileStreamInstance = new FileStream(path, mode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class for the specified file handle, with the specified read/write permission, and buffer size. 
        /// </summary>
        /// <param name="handle">A file handle for the file that the current FileStream object will encapsulate. </param>
        /// <param name="access">A FileAccess constant that sets the CanRead and CanWrite properties of the FileStream object. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes. </param>
        public FileStreamWrap(ISafeFileHandleWrap handle, FileAccess access, int bufferSize)
        {
            FileStreamInstance = new FileStream(handle.SafeFileHandleInstance, access, bufferSize);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path and creation mode. 
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access)
        {
            FileStreamInstance = new FileStream(path, mode, access);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class for the specified file handle, with the specified read/write permission, and buffer size, and synchronous or asynchronous state. 
        /// </summary>
        /// <param name="handle">A file handle for the file that the current FileStream object will encapsulate. </param>
        /// <param name="access">A FileAccess constant that sets the CanRead and CanWrite properties of the FileStream object. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes. </param>
        /// <param name="isAsync"> true if the handle was opened asynchronously (that is, in overlapped I/O mode); otherwise, false. </param>
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public FileStreamWrap(ISafeFileHandleWrap handle, FileAccess access, int bufferSize, bool isAsync)
        {
            FileStreamInstance = new FileStream(handle.SafeFileHandleInstance, access, bufferSize, isAsync);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write permission, and sharing permission.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share)
        {
            FileStreamInstance = new FileStream(path, mode, access, share);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write permission, and sharing permission, and buffer size.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes. </param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
        {
            FileStreamInstance = new FileStream(path, mode, access, share, bufferSize);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write permission, and sharing permission, and buffer size.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="useAsync">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
        {
            FileStreamInstance = new FileStream(path, mode, access, share, bufferSize, useAsync);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path, creation mode, read/write and sharing permission, the access other FileStreams can have to the same file, the buffer size, and additional file options.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="access">A FileAccess constant that determines how the file can be accessed by the FileStream object. This gets the CanRead and CanWrite properties of the FileStream object. CanSeek is true if path specifies a disk file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="options">A FileOptions value that specifies additional file options.</param>
        public FileStreamWrap(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            FileStreamInstance = new FileStream(path, mode, access, share, bufferSize, options);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path, creation mode, access rights and sharing permission, the buffer size, and additional file options.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="rights">A FileSystemRights constant that determines the access rights to use when creating access and audit rules for the file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="options">A FileOptions value that specifies additional file options.</param>
        public FileStreamWrap(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options)
        {
            FileStreamInstance = new FileStream(path, mode, rights, share, bufferSize, options);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class with the specified path, creation mode, access rights and sharing permission, the buffer size, additional file options, access control and audit security.
        /// </summary>
        /// <param name="path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <param name="mode">A FileMode constant that determines how to open or create the file.</param>
        /// <param name="rights">A FileSystemRights constant that determines the access rights to use when creating access and audit rules for the file.</param>
        /// <param name="share">A FileShare constant that determines how the file will be shared by processes. </param>
        /// <param name="bufferSize">A positive Int32 value greater than 0 indicating the buffer size. For bufferSize values between one and eight, the actual buffer size is set to eight bytes.</param>
        /// <param name="options">A FileOptions value that specifies additional file options.</param>
        /// <param name="fileSecurity">A FileSecurity constant that determines the access control and audit security for the file.</param>
        public FileStreamWrap(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity)
        {
            FileStreamInstance = new FileStream(path, mode, rights, share, bufferSize, options, fileSecurity);
        }

        public override bool CanRead
        {
            get { return FileStreamInstance.CanRead; }
        }

        public override bool CanSeek
        {
            get { return FileStreamInstance.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return FileStreamInstance.CanWrite; }
        }

        public FileStream FileStreamInstance { get; private set; }

        public bool IsAsync
        {
            get { return FileStreamInstance.IsAsync; }
        }

        public override long Length
        {
            get { return FileStreamInstance.Length; }
        }

        public string Name
        {
            get { return FileStreamInstance.Name; }
        }

        public override long Position
        {
            get { return FileStreamInstance.Position; }
            set { FileStreamInstance.Position = value; }
        }

        public ISafeFileHandleWrap SafeFileHandle
        {
            get { return new SafeFileHandleWrap(FileStreamInstance.SafeFileHandle); }
        }

        public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            return FileStreamInstance.BeginRead(array, offset, numBytes, userCallback, stateObject);
        }

        public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            return FileStreamInstance.BeginWrite(array, offset, numBytes, userCallback, stateObject);
        }

        public override void Flush()
        {
            throw new System.NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new System.NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new System.NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new System.NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new System.NotImplementedException();
        }
    }
}