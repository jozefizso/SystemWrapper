using System.IO;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.DirectoryInfo"/> class.
    /// </summary>
    public class DirectoryInfoWrap : FileSystemInfo, IDirectoryInfoWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="directoryInfo">A <see cref="T:System.IO.DirectoryInfo"/> object.</param>
        public DirectoryInfoWrap(DirectoryInfo directoryInfo)
        {
            DirectoryInfo = directoryInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="path">A string specifying the path on which to create the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/>. </param>
        public DirectoryInfoWrap(string path)
        {
            DirectoryInfo = new DirectoryInfo(path);
        }

        public DirectoryInfo DirectoryInfo { get; private set; }

        public override bool Exists
        {
            get { return DirectoryInfo.Exists; }
        }

        public override string Name
        {
            get { return DirectoryInfo.Name; }
        }

        public IDirectoryInfoWrap Parent
        {
            get { return new DirectoryInfoWrap(DirectoryInfo.Parent); }
        }

        public IDirectoryInfoWrap Root
        {
            get { return new DirectoryInfoWrap(DirectoryInfo.Root); }
        }

        public void Create()
        {
            DirectoryInfo.Create();
        }

        public void Create(IDirectorySecurityWrap directorySecurity)
        {
            DirectoryInfo.Create(directorySecurity.DirectorySecurity);
        }

        public IDirectoryInfoWrap CreateSubdirectory(string path)
        {
            return new DirectoryInfoWrap(DirectoryInfo.CreateSubdirectory(path));
        }

        public IDirectoryInfoWrap CreateSubdirectory(string path, IDirectorySecurityWrap directorySecurity)
        {
            return new DirectoryInfoWrap(DirectoryInfo.CreateSubdirectory(path, directorySecurity.DirectorySecurity));
        }

        public override void Delete()
        {
            DirectoryInfo.Delete();
        }

        public void Delete(bool recursive)
        {
            DirectoryInfo.Delete(recursive);
        }

        public IDirectorySecurityWrap GetAccessControl()
        {
            return new DirectorySecurityWrap(DirectoryInfo.GetAccessControl());
        }

        public IDirectorySecurityWrap GetAccessControl(AccessControlSections includeSections)
        {
            return new DirectorySecurityWrap(DirectoryInfo.GetAccessControl(includeSections));
        }

        public IDirectoryInfoWrap[] GetDirectories()
        {
            DirectoryInfo[] directoryInfos = DirectoryInfo.GetDirectories();
            return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
        }

        public IDirectoryInfoWrap[] GetDirectories(string searchPattern)
        {
            DirectoryInfo[] directoryInfos = DirectoryInfo.GetDirectories(searchPattern);
            return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
        }

        public IDirectoryInfoWrap[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            DirectoryInfo[] directoryInfos = DirectoryInfo.GetDirectories(searchPattern, searchOption);
            return ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(directoryInfos);
        }

        public IFileInfoWrap[] GetFiles()
        {
            FileInfo[] fileInfos = DirectoryInfo.GetFiles();
            return FileInfoWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(fileInfos);
        }

        public IFileInfoWrap[] GetFiles(string searchPattern)
        {
            FileInfo[] fileInfos = DirectoryInfo.GetFiles(searchPattern);
            return FileInfoWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(fileInfos);
        }

        public IFileInfoWrap[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            FileInfo[] fileInfos = DirectoryInfo.GetFiles(searchPattern, searchOption);
            return FileInfoWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(fileInfos);
        }

        public FileSystemInfo[] GetFileSystemInfos()
        {
            return DirectoryInfo.GetFileSystemInfos();
        }

        public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return DirectoryInfo.GetFileSystemInfos(searchPattern);
        }

        public void MoveTo(string destDirName)
        {
            DirectoryInfo.MoveTo(destDirName);
        }

        public void SetAccessControl(IDirectorySecurityWrap directorySecurity)
        {
            DirectoryInfo.SetAccessControl(directorySecurity.DirectorySecurity);
        }

        private static IDirectoryInfoWrap[] ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(DirectoryInfo[] directoryInfos)
        {
            IDirectoryInfoWrap[] directoryInfoWraps = new DirectoryInfoWrap[directoryInfos.Length];
            for (int i = 0; i < directoryInfos.Length; i++)
                directoryInfoWraps[i] = new DirectoryInfoWrap(directoryInfos[i]);
            return directoryInfoWraps;
        }

        public override string ToString()
        {
            return DirectoryInfo.ToString();
        }
    }
}