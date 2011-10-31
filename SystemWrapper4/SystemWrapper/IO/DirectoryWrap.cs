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
        /// <inheritdoc />
        public IDirectoryInfoWrap CreateDirectory(string path)
        {
            DirectoryInfo di = Directory.CreateDirectory(path);
            return new DirectoryInfoWrap(di);
        }

        /// <inheritdoc />
        public IDirectoryInfoWrap CreateDirectory(string path, IDirectorySecurityWrap directorySecurity)
        {
            if (directorySecurity == null)
                throw new ArgumentNullException("directorySecurity");
            DirectoryInfo di = Directory.CreateDirectory(path, directorySecurity.DirectorySecurityInstance);
            return new DirectoryInfoWrap(di);
        }

        /// <inheritdoc />
        public void Delete(string path)
        {
            Directory.Delete(path);
        }

        /// <inheritdoc />
        public void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        /// <inheritdoc />
        public IDirectorySecurityWrap GetAccessControl(string path)
        {
            return new DirectorySecurityWrap(Directory.GetAccessControl(path));
        }

        /// <inheritdoc />
        public IDirectorySecurityWrap GetAccessControl(string path, AccessControlSections includeSections)
        {
            return new DirectorySecurityWrap(Directory.GetAccessControl(path, includeSections));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetCreationTime(string path)
        {
            return new DateTimeWrap(Directory.GetCreationTime(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetCreationTimeUtc(string path)
        {
            return new DateTimeWrap(Directory.GetCreationTimeUtc(path));
        }

        /// <inheritdoc />
        public string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern)
        {
            return Directory.GetDirectories(path, searchPattern);
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public string GetDirectoryRoot(string path)
        {
            return Directory.GetDirectoryRoot(path);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path)
        {
            return Directory.GetFileSystemEntries(path);
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return Directory.GetFileSystemEntries(path, searchPattern);
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastAccessTime(string path)
        {
            return new DateTimeWrap(Directory.GetLastAccessTime(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastAccessTimeUtc(string path)
        {
            return new DateTimeWrap(Directory.GetLastAccessTimeUtc(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastWriteTime(string path)
        {
            return new DateTimeWrap(Directory.GetLastWriteTime(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastWriteTimeUtc(string path)
        {
            return new DateTimeWrap(Directory.GetLastWriteTimeUtc(path));
        }

        /// <inheritdoc />
        public string[] GetLogicalDrives()
        {
            return Directory.GetLogicalDrives();
        }

        /// <inheritdoc />
        public IDirectoryInfoWrap GetParent(string path)
        {
            DirectoryInfo di = Directory.GetParent(path);
            return new DirectoryInfoWrap(di);
        }

        /// <inheritdoc />
        public void Move(string sourceDirName, string destDirName)
        {
            Directory.Move(sourceDirName, destDirName);
        }

        /// <inheritdoc />
        public void SetAccessControl(string path, IDirectorySecurityWrap directorySecurity)
        {
            if (directorySecurity == null)
                throw new ArgumentNullException("directorySecurity");
            Directory.SetAccessControl(path, directorySecurity.DirectorySecurityInstance);
        }

        /// <inheritdoc />
        public void SetCreationTime(string path, IDateTimeWrap creationTime)
        {
            Directory.SetCreationTime(path, creationTime.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetCreationTimeUtc(string path, IDateTimeWrap creationTimeUtc)
        {
            Directory.SetCreationTimeUtc(path, creationTimeUtc.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetCurrentDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }

        /// <inheritdoc />
        public void SetLastAccessTime(string path, IDateTimeWrap lastAccessTime)
        {
            Directory.SetLastAccessTime(path, lastAccessTime.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastAccessTimeUtc(string path, IDateTimeWrap lastAccessTimeUtc)
        {
            Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastWriteTime(string path, IDateTimeWrap lastWriteTime)
        {
            Directory.SetLastWriteTime(path, lastWriteTime.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastWriteTimeUtc(string path, IDateTimeWrap lastWriteTimeUtc)
        {
            Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc.DateTimeInstance);
        }
    }
}