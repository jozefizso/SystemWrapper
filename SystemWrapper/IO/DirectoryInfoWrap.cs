using System.IO;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.DirectoryInfo"/> class.
    /// </summary>
    public class DirectoryInfoWrap : IDirectoryInfoWrap
    {
        readonly DirectoryInfo _directoryInfo;

        public DirectoryInfoWrap(DirectoryInfo directoryInfo)
        {
            _directoryInfo = directoryInfo;
        }

        public bool Exists
        {
            get { return _directoryInfo.Exists; }
        }

        public string Name
        {
            get { return _directoryInfo.Name; }
        }
    }
}