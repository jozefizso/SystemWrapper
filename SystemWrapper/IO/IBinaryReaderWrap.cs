using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of IBinaryReaderWrap.
	/// </summary>
	public interface IBinaryReaderWrap
	{
		int ReadInt32();
		char ReadChar();
		byte[] ReadBytes( int count );
		void Close();
		BinaryReader BinaryReaderInstance{ get; }
		//TODO
	}
	
}
