using System;
using System.IO.Compression;

namespace SystemWrapper.IO.Compression
{
	/// <summary>
	/// Description of IDeflateStreamWrap.
	/// </summary>
	public interface IDeflateStreamWrap
	{
		void Initialize(IStreamWrap stream, CompressionMode mode);

		int Read( byte[] array, int offset, int count );
		void Write( byte[] array, int offset, int count );
		void Flush();
		void Close();
		DeflateStream DeflateStreamInstance{ get; }
		//TODO
	}
}
