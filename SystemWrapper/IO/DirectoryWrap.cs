using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.Directory"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class DirectoryWrap : IDirectoryWrap
    {
        public IDirectoryInfoWrap CreateDirectory(string path)
        {
            DirectoryInfo di = Directory.CreateDirectory(path);
            return new DirectoryInfoWrap(di);
        }

        public IDirectoryInfoWrap CreateDirectory(string path, IDirectorySecurityWrap directorySecurity)
        {
            if (directorySecurity == null)
                throw new ArgumentNullException("directorySecurity");
            DirectoryInfo di = Directory.CreateDirectory(path, directorySecurity.DirectorySecurityInstance);
            return new DirectoryInfoWrap(di);
        }

        public void Delete(string path)
        {
            Directory.Delete(path);
        }

        public void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        public IDirectorySecurityWrap GetAccessControl(string path)
        {
            return new DirectorySecurityWrap(Directory.GetAccessControl(path));
        }

        public IDirectorySecurityWrap GetAccessControl(string path, AccessControlSections includeSections)
        {
            return new DirectorySecurityWrap(Directory.GetAccessControl(path, includeSections));
        }

        public IDateTimeWrap GetCreationTime(string path)
        {
            return new DateTimeWrap(Directory.GetCreationTime(path));
        }

        public IDateTimeWrap GetCreationTimeUtc(string path)
        {
            return new DateTimeWrap(Directory.GetCreationTimeUtc(path));
        }

        public string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        public string[] GetDirectories(string path, string searchPattern)
        {
            return Directory.GetDirectories(path, searchPattern);
        }

        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(path, searchPattern, searchOption);
        }

        public string GetDirectoryRoot(string path)
        {
            return Directory.GetDirectoryRoot(path);
        }

        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        public string[] GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, searchPattern, searchOption);
        }

        public string[] GetFileSystemEntries(string path)
        {
            return Directory.GetFileSystemEntries(path);
        }

        public string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return Directory.GetFileSystemEntries(path, searchPattern);
        }

        public IDateTimeWrap GetLastAccessTime(string path)
        {
            return new DateTimeWrap(Directory.GetLastAccessTime(path));
        }

        public IDateTimeWrap GetLastAccessTimeUtc(string path)
        {
            return new DateTimeWrap(Directory.GetLastAccessTimeUtc(path));
        }

        public IDateTimeWrap GetLastWriteTime(string path)
        {
            return new DateTimeWrap(Directory.GetLastWriteTime(path));
        }

        public IDateTimeWrap GetLastWriteTimeUtc(string path)
        {
            return new DateTimeWrap(Directory.GetLastWriteTimeUtc(path));
        }

        public string[] GetLogicalDrives()
        {
            return Directory.GetLogicalDrives();
        }

        public IDirectoryInfoWrap GetParent(string path)
        {
            DirectoryInfo di = Directory.GetParent(path);
            return new DirectoryInfoWrap(di);
        }

        public void Move(string sourceDirName, string destDirName)
        {
            Directory.Move(sourceDirName, destDirName);
        }

        public void SetAccessControl(string path, IDirectorySecurityWrap directorySecurity)
        {
            if (directorySecurity == null)
                throw new ArgumentNullException("directorySecurity");
            Directory.SetAccessControl(path, directorySecurity.DirectorySecurityInstance);
        }

        public void SetCreationTime(string path, IDateTimeWrap creationTime)
        {
            Directory.SetCreationTime(path, creationTime.DateTimeInstance);
        }

        public void SetCreationTimeUtc(string path, IDateTimeWrap creationTimeUtc)
        {
            Directory.SetCreationTimeUtc(path, creationTimeUtc.DateTimeInstance);
        }

        public void SetCurrentDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }

        public void SetLastAccessTime(string path, IDateTimeWrap lastAccessTime)
        {
            Directory.SetLastAccessTime(path, lastAccessTime.DateTimeInstance);
        }

        public void SetLastAccessTimeUtc(string path, IDateTimeWrap lastAccessTimeUtc)
        {
            Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc.DateTimeInstance);
        }

        public void SetLastWriteTime(string path, IDateTimeWrap lastWriteTime)
        {
            Directory.SetLastWriteTime(path, lastWriteTime.DateTimeInstance);
        }

        public void SetLastWriteTimeUtc(string path, IDateTimeWrap lastWriteTimeUtc)
        {
            Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc.DateTimeInstance);
        }
    }
}