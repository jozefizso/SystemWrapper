namespace SystemInterface.Diagnostics
{
    public interface IFileVersionInfoFactory : IStaticWrapper
    {
        IFileVersionInfo GetVersionInfo(string fileName);
    }
}
