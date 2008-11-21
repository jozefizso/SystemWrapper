using System.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    public class DirectorySecurityWrap : IDirectorySecurityWrap
    {
        readonly DirectorySecurity _directorySecurity;

        public DirectorySecurityWrap(DirectorySecurity directorySecurity)
        {
            _directorySecurity = directorySecurity;
        }

        public DirectorySecurity DirectorySecurity
        {
            get { return _directorySecurity; }
        }
    }
}