using System;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of IMemoryStreamWrap.
	/// </summary>
	public interface IMemoryStreamWrap : IStreamWrap
	{
		byte[] ToArray();
		//TODO
	}
}
