namespace SystemWrapper.IO
{
    public interface IDirectoryInfoWrap
    {
        // Methods

        // Properties
        bool Exists { get; }
        string Name { get; }
//        public DirectoryInfo Parent { get; }
//        public DirectoryInfo Root { get; }
        /*
                  public DirectoryInfo(string path);
            private DirectoryInfo(SerializationInfo info, StreamingContext context);
            internal DirectoryInfo(string fullPath, bool junk);
            public void Create();
            public void Create(DirectorySecurity directorySecurity);
            public DirectoryInfo CreateSubdirectory(string path);
            public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity);
            public override void Delete();
            public void Delete(bool recursive);
            private string FixupFileDirFullPath(string fileDirUserPath);
            public DirectorySecurity GetAccessControl();
            public DirectorySecurity GetAccessControl(AccessControlSections includeSections);
            public DirectoryInfo[] GetDirectories();
            public DirectoryInfo[] GetDirectories(string searchPattern);
            public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);
            public FileInfo[] GetFiles();
            public FileInfo[] GetFiles(string searchPattern);
            public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption);
            public FileSystemInfo[] GetFileSystemInfos();
            public FileSystemInfo[] GetFileSystemInfos(string searchPattern);
            private FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
            public void MoveTo(string destDirName);
            public void SetAccessControl(DirectorySecurity directorySecurity);
            public override string ToString();

            // Properties
            public override bool Exists { get; }
            public override string Name { get; }
            public DirectoryInfo Parent { get; }
            public DirectoryInfo Root { get; }
        */

    }
}