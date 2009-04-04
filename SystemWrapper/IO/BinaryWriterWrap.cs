using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of BinaryWriterWrap.
	/// </summary>
	public class BinaryWriterWrap : IBinaryWriterWrap
	{
		public BinaryWriter BinaryWriterInstance{ get; private set; }
		
		public BinaryWriterWrap( IStreamWrap output )
		{
			BinaryWriterInstance = new BinaryWriter( output.StreamInstance );
		}
		
		public void Write( int value )
		{
			BinaryWriterInstance.Write( value );
		}
		
		public void Write( byte[] value )
		{
			BinaryWriterInstance.Write( value );
		}
		
		public void Close()
		{
			BinaryWriterInstance.Close();
		}
	}
}
