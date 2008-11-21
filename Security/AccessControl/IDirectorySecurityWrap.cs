using System.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    public interface IDirectorySecurityWrap
    {
        DirectorySecurity DirectorySecurity { get; }
    }
}