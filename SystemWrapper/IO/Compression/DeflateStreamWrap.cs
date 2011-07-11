using System;
using System.IO.Compression;

namespace SystemWrapper.IO.Compression
{
	/// <summary>
	/// Description of DeflateStreamWrap.
	/// </summary>
	public class DeflateStreamWrap : IDeflateStreamWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Creates an uninitialized version of DeflateStreamWrap
		/// </summary>
		public DeflateStreamWrap()
		{
			//this constructor assumes caller will make a subsequent call to Initialize
		}

		public DeflateStreamWrap(IStreamWrap stream, CompressionMode mode)
		{
			Initialize(stream, mode);
		}

		public void Initialize(IStreamWrap stream, CompressionMode mode)
		{
			DeflateStreamInstance = new DeflateStream(stream.StreamInstance, mode);
		}

		#endregion Constructors and Initializers

		public int Read(byte[] array, int offset, int count)
		{
			return DeflateStreamInstance.Read( array, offset, count );
		}
		public void Write( byte[] array, int offset, int count )
		{
			DeflateStreamInstance.Write( array, offset, count );
		}
		public void Flush()
		{
			DeflateStreamInstance.Flush();
		}
		public void Close()
		{
			DeflateStreamInstance.Close();
		}
		
		public DeflateStream DeflateStreamInstance{ get; private set; }
	}
}
