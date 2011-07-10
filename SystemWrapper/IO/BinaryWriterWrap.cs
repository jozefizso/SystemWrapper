using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.BinaryWriter"/> class.
	/// </summary>
	[Serializable, ComVisible(true)]
	public class BinaryWriterWrap :IBinaryWriterWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.BinaryWriterWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.BinaryWriter"/> object.</param>
		public BinaryWriterWrap(BinaryWriter writer)
		{
			Initialize(writer);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.BinaryWriterWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="writer">The <see cref="T:System.IO.BinaryWriter"/> object.</param>
		public void Initialize(BinaryWriter writer)
		{
			BinaryWriterInstance = writer;
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and using UTF-8 as the encoding for strings.
		/// </summary>
		/// <param name="output">The output stream.</param>
		public BinaryWriterWrap(Stream output)
		{
			Initialize(output);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and using UTF-8 as the encoding for strings.
		/// </summary>
		/// <param name="output">The output stream.</param>
		public void Initialize(Stream output)
		{
			BinaryWriterInstance = new BinaryWriter(output);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and using UTF-8 as the encoding for strings.
		/// </summary>
		/// <param name="output">The output stream.</param>
		public BinaryWriterWrap(IStreamWrap output)
		{
			Initialize(output.StreamInstance);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and using UTF-8 as the encoding for strings.
		/// </summary>
		/// <param name="output">The output stream.</param>
		public void Initialize(IStreamWrap output)
		{
			BinaryWriterInstance = new BinaryWriter(output.StreamInstance);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="output">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public BinaryWriterWrap(Stream output, Encoding encoding)
		{
			Initialize(output, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="output">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public void Initialize(Stream output, Encoding encoding)
		{
			BinaryWriterInstance = new BinaryWriter(output, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="output">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public BinaryWriterWrap(IStreamWrap output, Encoding encoding)
		{
			Initialize(output.StreamInstance, encoding);
		}

		/// <summary>
		/// Initializes a new instance of the BinaryWriterWrap class based on the supplied stream and a specific character encoding.
		/// </summary>
		/// <param name="output">The supplied stream.</param>
		/// <param name="encoding">The character encoding.</param>
		public void Initialize(IStreamWrap output, Encoding encoding)
		{
			BinaryWriterInstance = new BinaryWriter(output.StreamInstance, encoding);
		}

		#endregion

		public Stream BaseStream
		{
			get { return BinaryWriterInstance.BaseStream; }
		}

		public BinaryWriter BinaryWriterInstance { get; private set; }

		public void Close()
		{
			BinaryWriterInstance.Close();
		}

		public void Flush()
		{
			BinaryWriterInstance.Flush();
		}

		public long Seek(int offset, SeekOrigin origin)
		{
			return BinaryWriterInstance.Seek(offset, origin);
		}

		public void Write(bool value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(byte value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(byte[] buffer)
		{
			BinaryWriterInstance.Write(buffer);
		}

		public void Write(char ch)
		{
			BinaryWriterInstance.Write(ch);
		}

		public void Write(char[] chars)
		{
			BinaryWriterInstance.Write(chars);
		}

		public void Write(decimal value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(double value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(short value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(int value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(long value)
		{
			BinaryWriterInstance.Write(value);
		}

		[CLSCompliant(false)]
		public void Write(sbyte value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(float value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(string value)
		{
			BinaryWriterInstance.Write(value);
		}

		[CLSCompliant(false)]
		public void Write(ushort value)
		{
			BinaryWriterInstance.Write(value);
		}

		[CLSCompliant(false)]
		public void Write(uint value)
		{
			BinaryWriterInstance.Write(value);
		}

		[CLSCompliant(false)]
		public void Write(ulong value)
		{
			BinaryWriterInstance.Write(value);
		}

		public void Write(byte[] buffer, int index, int count)
		{
			BinaryWriterInstance.Write(buffer, index, count);
		}

		public void Write(char[] chars, int index, int count)
		{
			BinaryWriterInstance.Write(chars, index, count);
		}

		public void Dispose()
		{
			BinaryWriterInstance.Close();
		}
	}
}
