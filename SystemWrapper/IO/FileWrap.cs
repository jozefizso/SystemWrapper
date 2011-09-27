using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.File"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class FileWrap : IFileWrap
    {
        /// <inheritdoc />
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        /// <inheritdoc />
        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }

        /// <inheritdoc />
        public IStreamWriterWrap AppendText(string path)
        {
            return new StreamWriterWrap(File.AppendText(path));
        }

        /// <inheritdoc />
        public void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName);
        }

        /// <inheritdoc />
        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <inheritdoc />
        public IFileStreamWrap Create(string path)
        {
            return new FileStreamWrap(File.Create(path));
        }

        /// <inheritdoc />
        public IFileStreamWrap Create(string path, int bufferSize)
        {
            return new FileStreamWrap(File.Create(path, bufferSize));
        }

        /// <inheritdoc />
        public IFileStreamWrap Create(string path, int bufferSize, FileOptions options)
        {
            return new FileStreamWrap(File.Create(path, bufferSize, options));
        }

        /// <inheritdoc />
        public IFileStreamWrap Create(string path, int bufferSize, FileOptions options, IFileSecurityWrap fileSecurity)
        {
            return new FileStreamWrap(File.Create(path, bufferSize, options, fileSecurity.FileSecurityInstance));
        }

        /// <inheritdoc />
        public IStreamWriterWrap CreateText(string path)
        {
            return new StreamWriterWrap(File.CreateText(path));
        }

        /// <inheritdoc />
        public void Decrypt(string path)
        {
            File.Decrypt(path);
        }

        /// <inheritdoc />
        public void Delete(string path)
        {
            File.Delete(path);
        }

        /// <inheritdoc />
        public void Encrypt(string path)
        {
            File.Encrypt(path);
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <inheritdoc />
        public IFileSecurityWrap GetAccessControl(string path)
        {
            return new FileSecurityWrap(File.GetAccessControl(path));
        }

        /// <inheritdoc />
        public IFileSecurityWrap GetAccessControl(string path, AccessControlSections includeSections)
        {
            return new FileSecurityWrap(File.GetAccessControl(path, includeSections));
        }

        /// <inheritdoc />
        public FileAttributes GetAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        /// <inheritdoc />
        public IDateTimeWrap GetCreationTime(string path)
        {
            return new DateTimeWrap(File.GetCreationTime(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetCreationTimeUtc(string path)
        {
            return new DateTimeWrap(File.GetCreationTimeUtc(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastAccessTime(string path)
        {
            return new DateTimeWrap(File.GetLastAccessTime(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastAccessTimeUtc(string path)
        {
            return new DateTimeWrap(File.GetLastAccessTimeUtc(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastWriteTime(string path)
        {
            return new DateTimeWrap(File.GetLastWriteTime(path));
        }

        /// <inheritdoc />
        public IDateTimeWrap GetLastWriteTimeUtc(string path)
        {
            return new DateTimeWrap(File.GetLastWriteTimeUtc(path));
        }

        /// <inheritdoc />
        public void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        /// <inheritdoc />
        public IFileStreamWrap Open(string path, FileMode mode)
        {
            return new FileStreamWrap(File.Open(path, mode));
        }

        /// <inheritdoc />
        public IFileStreamWrap Open(string path, FileMode mode, FileAccess access)
        {
            return new FileStreamWrap(File.Open(path, mode, access));
        }

        /// <inheritdoc />
        public IFileStreamWrap Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return new FileStreamWrap(File.Open(path, mode, access, share));
        }

        /// <inheritdoc />
        public IFileStreamWrap OpenRead(string path)
        {
            return new FileStreamWrap(File.OpenRead(path));
        }

        /// <inheritdoc />
        public IStreamReaderWrap OpenText(string path)
        {
            return new StreamReaderWrap(File.OpenText(path));
        }

        /// <inheritdoc />
        public IFileStreamWrap OpenWrite(string path)
        {
            return new FileStreamWrap(File.OpenWrite(path));
        }

        /// <inheritdoc />
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        /// <inheritdoc />
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        /// <inheritdoc />
        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return File.ReadAllLines(path, encoding);
        }

        /// <inheritdoc />
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        /// <inheritdoc />
        public string ReadAllText(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        /// <inheritdoc />
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }

        /// <inheritdoc />
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

        /// <inheritdoc />
        public void SetAccessControl(string path, IFileSecurityWrap fileSecurity)
        {
            File.SetAccessControl(path, fileSecurity.FileSecurityInstance);
        }

        /// <inheritdoc />
        public void SetAttributes(string path, FileAttributes fileAttributes)
        {
            File.SetAttributes(path, fileAttributes);
        }

        /// <inheritdoc />
        public void SetCreationTime(string path, IDateTimeWrap creationTime)
        {
            File.SetCreationTime(path, creationTime.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetCreationTimeUtc(string path, IDateTimeWrap creationTimeUtc)
        {
            File.SetCreationTimeUtc(path, creationTimeUtc.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastAccessTime(string path, IDateTimeWrap lastAccessTime)
        {
            File.SetLastAccessTime(path, lastAccessTime.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastAccessTimeUtc(string path, IDateTimeWrap lastAccessTimeUtc)
        {
            File.SetLastAccessTimeUtc(path, lastAccessTimeUtc.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastWriteTime(string path, IDateTimeWrap lastWriteTime)
        {
            File.SetLastWriteTime(path, lastWriteTime.DateTimeInstance);
        }

        /// <inheritdoc />
        public void SetLastWriteTimeUtc(string path, IDateTimeWrap lastWriteTimeUtc)
        {
            File.SetLastWriteTimeUtc(path, lastWriteTimeUtc.DateTimeInstance);
        }

        /// <inheritdoc />
        public void WriteAllBytes(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        /// <inheritdoc />
        public void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }

        /// <inheritdoc />
        public void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        /// <inheritdoc />
        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }
    }
}
