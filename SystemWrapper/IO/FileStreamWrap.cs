using System.IO;
using System.Runtime.InteropServices;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    [ComVisible(true)]
    public class FileStreamWrap : IFileStreamWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileStreamWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileStream">A <see cref="T:System.IO.FileStream"/> object.</param>
        public FileStreamWrap(FileStream fileStream)
        {
            FileStreamInstance = fileStream;
        }

        public FileStream FileStreamInstance { get; private set; }

    }
}