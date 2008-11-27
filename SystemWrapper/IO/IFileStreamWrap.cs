using System.IO;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    public interface IFileStreamWrap
    {
        // Properties

        /// <summary>
        /// Gets <see cref="T:System.IO.FileStream"/> object.
        /// </summary>
        FileStream FileStreamInstance { get; }

        /*
                    // Methods
                    static FileStream();
                    internal FileStream();
                    public FileStream(SafeFileHandle handle, FileAccess access);
                    [Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
                    public FileStream(IntPtr handle, FileAccess access);
                    public FileStream(string path, FileMode mode);
                    public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize);
                    [Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  http://go.microsoft.com/fwlink/?linkid=14202")]
                    public FileStream(IntPtr handle, FileAccess access, bool ownsHandle);
                    public FileStream(string path, FileMode mode, FileAccess access);
                    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
                    public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync);
                    [Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  http://go.microsoft.com/fwlink/?linkid=14202")]
                    public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize);
                    public FileStream(string path, FileMode mode, FileAccess access, FileShare share);
                    [Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  http://go.microsoft.com/fwlink/?linkid=14202"), SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
                    public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync);
                    public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize);
                    public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync);
                    public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options);
                    public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options);
                    public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity);
                    internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy);
                    private static unsafe void AsyncFSCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped);
                    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
                    public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
                    private FileStreamAsyncResult BeginReadCore(byte[] bytes, int offset, int numBytes, AsyncCallback userCallback, object stateObject, int numBufferedBytesRead);
                    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
                    public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
                    private FileStreamAsyncResult BeginWriteCore(byte[] bytes, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
                    protected override void Dispose(bool disposing);
                    public override int EndRead(IAsyncResult asyncResult);
                    public override void EndWrite(IAsyncResult asyncResult);
                    protected override void Finalize();
                    public override void Flush();
                    private void FlushRead();
                    private void FlushWrite(bool calledFromFinalizer);
                    public FileSecurity GetAccessControl();
                    private static Win32Native.SECURITY_ATTRIBUTES GetSecAttrs(FileShare share);
                    private static Win32Native.SECURITY_ATTRIBUTES GetSecAttrs(FileShare share, FileSecurity fileSecurity, out object pinningHandle);
                    internal void Init(string path, FileMode mode, FileAccess access, int rights, bool useRights, FileShare share, int bufferSize, FileOptions options, Win32Native.SECURITY_ATTRIBUTES secAttrs, string msgPath, bool bFromProxy);
                    public virtual void Lock(long position, long length);
                    public override int Read([In, Out] byte[] array, int offset, int count);
                    public override int ReadByte();
                    private int ReadCore(byte[] buffer, int offset, int count);
                    private unsafe int ReadFileNative(SafeFileHandle handle, byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr);
                    public override long Seek(long offset, SeekOrigin origin);
                    private long SeekCore(long offset, SeekOrigin origin);
                    public void SetAccessControl(FileSecurity fileSecurity);
                    public override void SetLength(long value);
                    private void SetLengthCore(long value);
                    public virtual void Unlock(long position, long length);
                    private void VerifyHandleIsSync();
                    private void VerifyOSHandlePosition();
                    public override void Write(byte[] array, int offset, int count);
                    public override void WriteByte(byte value);
                    private void WriteCore(byte[] buffer, int offset, int count);
                    private unsafe int WriteFileNative(SafeFileHandle handle, byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr);

                    // Properties
                    public override bool CanRead { get; }
                    public override bool CanSeek { get; }
                    public override bool CanWrite { get; }
                    [Obsolete("This property has been deprecated.  Please use FileStream's SafeFileHandle property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
                    public virtual IntPtr Handle { [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode), SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get; }
                    public virtual bool IsAsync { get; }
                    public override long Length { get; }
                    public string Name { get; }
                    internal string NameInternal { get; }
                    public override long Position { get; set; }
                    public virtual SafeFileHandle SafeFileHandle { [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode), SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get; }
        */
    }
}