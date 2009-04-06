using System;
using System.IO;
using System.Text;

namespace SystemWrapper.IO
{
	/// <summary>
    /// Wrapper for <see cref="T:System.IO.File"/> class.
	/// </summary>
	public interface IFileWrap
	{
        // Methods

        /// <summary>
        /// Opens a file, appends the specified string to the file, and then closes the file. If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        void AppendAllText(string path, string contents);
        /// <summary>
        /// Appends the specified string to the file, creating the file if it does not already exist.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        void AppendAllText(string path, string contents, Encoding encoding);
        /// <summary>
        /// Creates a IStreamWriterWrap that appends UTF-8 encoded text to an existing file. 
        /// </summary>
        /// <param name="path">The path to the file to append to.</param>
        /// <returns>A IStreamWriterWrap that appends UTF-8 encoded text to an existing file.</returns>
        IStreamWriterWrap AppendText(string path);
        bool Create(string path);
        bool Exists(string path);
        void Delete(string path);
        IFileStreamWrap Open(string path, FileMode mode);
		IFileStreamWrap Open( string path, FileMode mode, FileAccess access );
		//TODO

/*
        public static void Copy(string sourceFileName, string destFileName);
        public static void Copy(string sourceFileName, string destFileName, bool overwrite);
        public static FileStream Create(string path);
        public static FileStream Create(string path, int bufferSize);
        public static FileStream Create(string path, int bufferSize, FileOptions options);
        public static FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity);
        public static StreamWriter CreateText(string path);
        public static void Decrypt(string path);
        public static void Delete(string path);
        public static void Encrypt(string path);
        public static bool Exists(string path);
        public static FileSecurity GetAccessControl(string path);
        public static FileSecurity GetAccessControl(string path, AccessControlSections includeSections);
        public static FileAttributes GetAttributes(string path);
        public static DateTime GetCreationTime(string path);
        public static DateTime GetCreationTimeUtc(string path);
        public static DateTime GetLastAccessTime(string path);
        public static DateTime GetLastAccessTimeUtc(string path);
        public static DateTime GetLastWriteTime(string path);
        public static DateTime GetLastWriteTimeUtc(string path);
        public static void Move(string sourceFileName, string destFileName);
        public static FileStream Open(string path, FileMode mode);
        public static FileStream Open(string path, FileMode mode, FileAccess access);
        public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);
        public static FileStream OpenRead(string path);
        public static StreamReader OpenText(string path);
        public static FileStream OpenWrite(string path);
        public static byte[] ReadAllBytes(string path);
        public static string[] ReadAllLines(string path);
        public static string[] ReadAllLines(string path, Encoding encoding);
        public static string ReadAllText(string path);
        public static string ReadAllText(string path, Encoding encoding);
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
        public static void SetAccessControl(string path, FileSecurity fileSecurity);
        public static void SetAttributes(string path, FileAttributes fileAttributes);
        public static void SetCreationTime(string path, DateTime creationTime);
        public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        public static void SetLastAccessTime(string path, DateTime lastAccessTime);
        public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        public static void SetLastWriteTime(string path, DateTime lastWriteTime);
        public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
        public static void WriteAllBytes(string path, byte[] bytes);
        public static void WriteAllLines(string path, string[] contents);
        public static void WriteAllLines(string path, string[] contents, Encoding encoding);
        public static void WriteAllText(string path, string contents);
        public static void WriteAllText(string path, string contents, Encoding encoding);
*/

	}
}
