using System;
using System.IO;
using System.Text;

namespace SystemWrapper.IO
{
	/// <summary>
    /// Description of FileWrap.
	/// </summary>
	public class FileWrap : IFileWrap
	{
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }

	    public IStreamWriterWrap AppendText(string path)
	    {
	        return new StreamWriterWrap(File.AppendText(path));
	    }

	    public bool Create(string path)
        {
            return File.Exists(path);
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }
	
		public IFileStreamWrap Open( string path, FileMode mode )
		{
			return new FileStreamWrap( File.Open( path, mode ) );
		}
		
		public IFileStreamWrap Open( string path, FileMode mode, FileAccess access )
		{
			return new FileStreamWrap( File.Open( path, mode, access ) );
		}
	}
}
