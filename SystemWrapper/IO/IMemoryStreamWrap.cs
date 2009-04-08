using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
    /// Wrapper for <see cref="T:System.IO.MemoryStream"/> class.
    /// </summary>
	public interface IMemoryStreamWrap : IStreamWrap
	{
        // Properties

        /// <summary>
        /// Gets <see cref="T:System.IO.MemoryStream"/> object.
        /// </summary>
        MemoryStream MemoryStreamInstance { get; }

        byte[] ToArray();
		//TODO

          // Methods
/*
    public MemoryStream();
    public MemoryStream(int capacity);
    public MemoryStream(byte[] buffer);
    public MemoryStream(byte[] buffer, bool writable);
    public MemoryStream(byte[] buffer, int index, int count);
    public MemoryStream(byte[] buffer, int index, int count, bool writable);
    public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible);
    protected override void Dispose(bool disposing);
    private bool EnsureCapacity(int value);
    public override void Flush();
    public virtual byte[] GetBuffer();
    internal int InternalEmulateRead(int count);
    internal byte[] InternalGetBuffer();
    internal void InternalGetOriginAndLength(out int origin, out int length);
    internal int InternalGetPosition();
    internal int InternalReadInt32();
    public override int Read([In, Out] byte[] buffer, int offset, int count);
    public override int ReadByte();
    public override long Seek(long offset, SeekOrigin loc);
    public override void SetLength(long value);
    public virtual byte[] ToArray();
    public override void Write(byte[] buffer, int offset, int count);
    public override void WriteByte(byte value);
    public virtual void WriteTo(Stream stream);

    // Properties
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public virtual int Capacity { get; set; }
    public override long Length { get; }
    public override long Position { get; set; }
*/

	}
}
