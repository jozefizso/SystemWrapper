using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of MemoryStreamWrap.
	/// </summary>
	public class MemoryStreamWrap : IMemoryStreamWrap
	{
		MemoryStream ms;
		public MemoryStreamWrap()
		{
			ms = new MemoryStream();
		}
		public MemoryStreamWrap( byte[] buffer )
		{
			ms = new MemoryStream( buffer );
		}
		
		public Stream StreamInstance{ get{ return ms; } }
		
		public byte[] ToArray()
		{
			return ms.ToArray();
		}
	}
}
