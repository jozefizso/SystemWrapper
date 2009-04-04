using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of BinaryReaderWrap.
	/// </summary>
	public class BinaryReaderWrap : IBinaryReaderWrap
	{
		public BinaryReaderWrap( IStreamWrap stream )
		{
			BinaryReaderInstance = new BinaryReader( stream.StreamInstance );
		}
		
		public BinaryReader BinaryReaderInstance{ get; private set; }
		
		public int ReadInt32()
		{
			return BinaryReaderInstance.ReadInt32();
		}
		
		public char ReadChar()
		{
			return BinaryReaderInstance.ReadChar();
		}
		
		public byte[] ReadBytes(int count )
		{
			return BinaryReaderInstance.ReadBytes( count );
		}
		
		public void Close()
		{
			BinaryReaderInstance.Close();
		}
	}
}
