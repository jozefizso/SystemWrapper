using SystemInterface.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    public class FileVersionInfoFactory : IFileVersionInfoFactory
    {
        public IFileVersionInfo GetVersionInfo(string fileName)
        {
            return new FileVersionInfoWrap(System.Diagnostics.FileVersionInfo.GetVersionInfo(fileName));
        }
    }
}
