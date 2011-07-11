using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.BinaryReader"/> class.
	/// </summary>
	[ComVisible(true)]
	public class BinaryReaderWrap : IBinaryReaderWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Creates an uninitialized instance of the <see cref="T:SystemWrapper.IO.BinaryReaderWrap"/> class on the specified path. 
		/// </summary>
		public BinaryReaderWrap()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.BinaryReaderWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="reader">The <see cref="T:System.IO.BinaryReader"/> object.</param>
		public BinaryReaderWrap(BinaryReader reader)
		{
			Initialize(reader);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.BinaryReaderWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="reader">The <see cref="T:System.IO.BinaryReader"/> object.</param>
		public void Initialize(BinaryReader reader)
		{
			BinaryReaderInstance = reader;
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and using UTF8Encoding. 
		/// </summary>
		/// <param name="input">A <see cref="T:System.IO.Stream"/> object.</param>
		public BinaryReaderWrap(Stream input)
		{
			Initialize(input);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and using UTF8Encoding. 
		/// </summary>
		/// <param name="input">A <see cref="T:System.IO.Stream"/> object.</param>
		public void Initialize(Stream input)
		{
			BinaryReaderInstance = new BinaryReader(input);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and using UTF8Encoding. 
		/// </summary>
		/// <param name="input">A <see cref="T:System.IO.Stream"/> object.</param>
		public BinaryReaderWrap(IStreamWrap input)
		{
			Initialize(input.StreamInstance);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and using UTF8Encoding. 
		/// </summary>
		/// <param name="input">A <see cref="T:System.IO.Stream"/> object.</param>
		public void Initialize(IStreamWrap input)
		{
			BinaryReaderInstance = new BinaryReader(input.StreamInstance);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="stream">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public BinaryReaderWrap(Stream stream, Encoding encoding)
		{
			Initialize(stream, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="stream">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public void Initialize(Stream stream, Encoding encoding)
		{
			BinaryReaderInstance = new BinaryReader(stream, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="stream">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public BinaryReaderWrap(IStreamWrap stream, Encoding encoding)
		{
			Initialize(stream.StreamInstance, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryReader class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="stream">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public void Initialize(IStreamWrap stream, Encoding encoding)
		{
			BinaryReaderInstance = new BinaryReader(stream.StreamInstance, encoding);
		}

		#endregion

		public Stream BaseStream
		{
			get { return BinaryReaderInstance.BaseStream; }
		}

		public BinaryReader BinaryReaderInstance{ get; private set; }

		public virtual void Close()
		{
			BinaryReaderInstance.Close();
		}

		public char[] ReadChars(int count)
		{
			return BinaryReaderInstance.ReadChars(count);
		}

		public decimal ReadDecimal()
		{
			return BinaryReaderInstance.ReadDecimal();
		}

		public double ReadDouble()
		{
			return BinaryReaderInstance.ReadDouble();
		}

		public short ReadInt16()
		{
			return BinaryReaderInstance.ReadInt16();
		}

		public int ReadInt32()
		{
			return BinaryReaderInstance.ReadInt32();
		}

		public long ReadInt64()
		{
			return BinaryReaderInstance.ReadInt64();
		}

		public char ReadChar()
		{
			return BinaryReaderInstance.ReadChar();
		}

		public int PeekChar()
		{
			return BinaryReaderInstance.PeekChar();
		}

		public int Read()
		{
			return BinaryReaderInstance.Read();
		}

		public int Read(byte[] buffer, int index, int count)
		{
			return BinaryReaderInstance.Read(buffer, index, count);
		}

		public int Read(char[] buffer, int index, int count)
		{
			return BinaryReaderInstance.Read(buffer, index, count);
		}

		public bool ReadBoolean()
		{
			return BinaryReaderInstance.ReadBoolean();
		}

		public byte ReadByte()
		{
			return BinaryReaderInstance.ReadByte();
		}

		public virtual byte[] ReadBytes(int count )
		{
			return BinaryReaderInstance.ReadBytes( count );
		}

		[CLSCompliant(false)]
		public sbyte ReadSByte()
		{
			return BinaryReaderInstance.ReadSByte();
		}

		public float ReadSingle()
		{
			return BinaryReaderInstance.ReadSingle();
		}

		public string ReadString()
		{
			return BinaryReaderInstance.ReadString();
		}

		[CLSCompliant(false)]
		public ushort ReadUInt16()
		{
			return BinaryReaderInstance.ReadUInt16();
		}

		[CLSCompliant(false)]
		public uint ReadUInt32()
		{
			return BinaryReaderInstance.ReadUInt32();
		}

		[CLSCompliant(false)]
		public ulong ReadUInt64()
		{
			return BinaryReaderInstance.ReadUInt64();
		}

		public void Dispose()
		{
			BinaryReaderInstance.Close();
		}
	}
}
