using System;
using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Description of FileWrap.
	/// </summary>
	public class FileWrap : IFileWrap
	{
		public FileWrap()
		{
		}
		
		public IFileStreamWrap Open( string path, FileMode mode )
		{
			return new FileStreamWrap( File.Open( path, mode ) );
		}
		
		public IFileStreamWrap Open( string path, FileMode mode, FileAccess access )
		{
			return new FileStreamWrap( File.Open( path, mode, access ) );
		}
		
		public void Delete( string path )
		{
			File.Delete( path );
		}
		
		public bool Exists( string path )
		{
			return File.Exists( path );
		}
		public bool Create( string path )
		{
			return File.Exists( path );
		}
	}
}
