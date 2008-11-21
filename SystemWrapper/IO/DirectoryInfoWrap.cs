using System.IO;

namespace SystemWrapper.IO
{
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