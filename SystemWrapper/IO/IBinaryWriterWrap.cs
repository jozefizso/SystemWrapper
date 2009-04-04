using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of IBinaryWriterWrap.
	/// </summary>
	public interface IBinaryWriterWrap
	{
		void Write( int value );
		void Write( byte[] value );
		void Close();
		BinaryWriter BinaryWriterInstance{ get; }
		//TODO
	}
}
