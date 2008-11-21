using System.IO;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    public class DirectoryWrap : IDirectoryWrap
    {
        public IDirectoryInfoWrap CreateDirectory(string path)
        {
            DirectoryInfo di = Directory.CreateDirectory(path);
            return new DirectoryInfoWrap(di);
        }

        public IDirectoryInfoWrap CreateDirectory(string path, IDirectorySecurityWrap directorySecurity)
        {
            DirectoryInfo di = Directory.CreateDirectory(path, directorySecurity.DirectorySecurity);
            return new DirectoryInfoWrap(di);
        }

        public void Delete(string path)
        {
            Directory.Delete(path);
        }

        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }
    }
}