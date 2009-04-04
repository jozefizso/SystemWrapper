using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of IFileWrap.
	/// </summary>
	public interface IFileWrap
	{
		IFileStreamWrap Open( string path, FileMode mode);
		void Delete( string path );
		bool Exists( string path );
		bool Create( string path );
		IFileStreamWrap Open( string path, FileMode mode, FileAccess access );
		//TODO
	}
}
