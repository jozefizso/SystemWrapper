using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
    /// </summary>
    public interface IFileInfoWrap
    {

    	/// <summary>
    	/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
    	/// </summary>
    	/// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
    	void Initialize(FileInfo fileInfo);

    	/// <summary>
    	/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
    	/// </summary>
    	/// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
    	void Initialize(string fileName);


        // Properties

        /// <summary>
        ///  Gets or sets the <see cref="System.IO.FileAttributes"/> of the current Gets or sets the creation time, in coordinated universal time (UTC), of the current FileSystemInfo object. . 
        /// </summary>
        FileAttributes Attributes { get; set; }
        /// <summary>
        /// Gets or sets the creation time of the current <see cref="T:System.IO.FileSystemInfo"/> object.
        /// </summary>
        IDateTimeWrap CreationTime { get; set; }
        /// <summary>
        /// Gets or sets the creation time, in coordinated universal time (UTC), of the current <see cref="T:System.IO.FileSystemInfo"/> object. 
        /// </summary>
        IDateTimeWrap CreationTimeUtc { get; set; }
        /// <summary>
        /// Gets an instance of the parent directory.
        /// </summary>
        IDirectoryInfoWrap Directory { get; }
        /// <summary>
        /// Gets a string representing the directory's full path.
        /// </summary>
        string DirectoryName { get; }
        /// <summary>
        /// Gets a value indicating whether a file exists. 
        /// </summary>
        bool Exists { get; }
        /// <summary>
        /// Gets the string representing the extension part of the file.
        /// </summary>
        string Extension { get; }
        /// <summary>
        /// Gets <see cref="T:System.IO.FileInfo"/> object.
        /// </summary>
        FileInfo FileInfoInstance { get; }
        /// <summary>
        /// Gets the full path of the directory or file.
        /// </summary>
        string FullName { get; }
        /// <summary>
        /// Gets or sets a value that determines if the current file is read only.
        /// </summary>
        bool IsReadOnly { get; set; }
        /// <summary>
        /// Gets or sets the time the current file or directory was last accessed. 
        /// </summary>
        IDateTimeWrap LastAccessTime { get; set; }
        /// <summary>
        /// Gets or sets the time, in coordinated universal time (UTC), that the current file or directory was last accessed.
        /// </summary>
        IDateTimeWrap LastAccessTimeUtc { get; set; }
        /// <summary>
        /// Gets or sets the time when the current file or directory was last written to.
        /// </summary>
        IDateTimeWrap LastWriteTime { get; set; }
        /// <summary>
        /// Gets or sets the time, in coordinated universal time (UTC), when the current file or directory was last written to.
        /// </summary>
        IDateTimeWrap LastWriteTimeUtc { get; set; }
        /// <summary>
        /// Gets the size, in bytes, of the current file.
        /// </summary>
        long Length { get; }
        /// <summary>
        /// Gets the name of the file. 
        /// </summary>
        string Name { get; }

        // Methods

        /// <summary>
        /// Creates a IStreamWriterWrap that appends text to the file represented by this instance of the IFileInfoWrap.
        /// </summary>
        /// <returns>A new IStreamWriterWrap.</returns>
        IStreamWriterWrap AppendText();
        /// <summary>
        /// Copies an existing file to a new file, disallowing the overwriting of an existing file.
        /// </summary>
        /// <param name="destFileName">The name of the new file to copy to.</param>
        /// <returns>A new file with a fully qualified path.</returns>
        IFileInfoWrap CopyTo(string destFileName);
        /// <summary>
        /// Copies an existing file to a new file, allowing the overwriting of an existing file. 
        /// </summary>
        /// <param name="destFileName">The name of the new file to copy to.</param>
        /// <param name="overwrite"> true to allow an existing file to be overwritten; otherwise, false. </param>
        /// <returns>A new file, or an overwrite of an existing file if overwrite is true. If the file exists and overwrite is false, an IOException is thrown.</returns>
        IFileInfoWrap CopyTo(string destFileName, bool overwrite);
        /// <summary>
        /// Creates a file.
        /// </summary>
        /// <returns></returns>
        IFileStreamWrap Create();
        /// <summary>
        /// Creates a IStreamWriterWrap that writes a new text file.
        /// </summary>
        /// <returns>A new IStreamWriterWrap.</returns>
        IStreamWriterWrap CreateText();
        /// <summary>
        /// Decrypts a file that was encrypted by the current account using the Encrypt method. 
        /// </summary>
        [ComVisible(false)]
        void Decrypt();
        /// <summary>
        /// Permanently deletes a file.
        /// </summary>
        void Delete();
        /// <summary>
        /// Encrypts a file so that only the account used to encrypt the file can decrypt it. 
        /// </summary>
        [ComVisible(false)]
        void Encrypt();
        /// <summary>
        /// Gets a IFileSecurityWrap object that encapsulates the access control list (ACL) entries for the file described by the current IFileInfoWrap object. 
        /// </summary>
        /// <returns>A IFileSecurityWrap object that encapsulates the access control rules for the current file. </returns>
        IFileSecurityWrap GetAccessControl();
        /// <summary>
        /// Gets a IFileSecurityWrap object that encapsulates the access control list (ACL) entries for the file described by the current IFileInfoWrap object. 
        /// </summary>
        /// <param name="includeSections">One of the AccessControlSections values that specifies which group of access control entries to retrieve. </param>
        /// <returns>A IFileSecurityWrap object that encapsulates the access control rules for the current file. </returns>
        IFileSecurityWrap GetAccessControl(AccessControlSections includeSections);
        /// <summary>
        /// Moves a specified file to a new location, providing the option to specify a new file name. 
        /// </summary>
        /// <param name="destFileName">The path to move the file to, which can specify a different file name.</param>
        void MoveTo(string destFileName);
        /// <summary>
        /// Opens a file in the specified mode.
        /// </summary>
        /// <param name="mode">A FileMode constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <returns>A file opened in the specified mode, with read/write access and unshared. </returns>
        IFileStreamWrap Open(FileMode mode);
        /// <summary>
        /// Opens a file in the specified mode.
        /// </summary>
        /// <param name="mode">A FileMode constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <param name="access">A FileAccess constant specifying whether to open the file with Read, Write, or ReadWrite file access.</param>
        /// <returns>A file opened in the specified mode, with read/write access and unshared. </returns>
        IFileStreamWrap Open(FileMode mode, FileAccess access);
        /// <summary>
        /// Opens a file in the specified mode.
        /// </summary>
        /// <param name="mode">A FileMode constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <param name="access">A FileAccess constant specifying whether to open the file with Read, Write, or ReadWrite file access.</param>
        /// <param name="share">A FileShare constant specifying the type of access other FileStream objects have to this file.</param>
        /// <returns>A file opened in the specified mode, with read/write access and unshared. </returns>
        IFileStreamWrap Open(FileMode mode, FileAccess access, FileShare share);
        /// <summary>
        /// Creates a read-only IFileStreamWrap. 
        /// </summary>
        /// <returns>A new read-only IFileStreamWrap object. </returns>
        IFileStreamWrap OpenRead();
        /// <summary>
        /// Creates a IStreamReaderWrap with UTF8 encoding that reads from an existing text file.
        /// </summary>
        /// <returns>A new IStreamReaderWrap with UTF8 encoding. </returns>
        IStreamReaderWrap OpenText();
        /// <summary>
        /// Creates a write-only IFileStreamWrap. 
        /// </summary>
        /// <returns>A new write-only unshared IFileStreamWrap object.</returns>
        IFileStreamWrap OpenWrite();
        /// <summary>
        /// Refreshes the state of the object.
        /// </summary>
        void Refresh();
        /// <summary>
        /// Replaces the contents of a specified file with the file described by the current IFileInfoWrap object, deleting the original file, and creating a backup of the replaced file.
        /// </summary>
        /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
        /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the destFileName parameter.</param>
        /// <returns>A IFileInfoWrap object that encapsulates information about the file described by the destFileName parameter.</returns>
        [ComVisible(false)]
        IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName);
        /// <summary>
        /// Replaces the contents of a specified file with the file described by the current FileInfo object, deleting the original file, and creating a backup of the replaced file. Also specifies whether to ignore merge errors.
        /// </summary>
        /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
        /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the destFileName parameter.</param>
        /// <param name="ignoreMetadataErrors"> true to ignore merge errors (such as attributes and ACLs) from the replaced file to the replacement file; otherwise false.</param>
        /// <returns>A IFileInfoWrap object that encapsulates information about the file described by the destFileName parameter.</returns>
        [ComVisible(false)]
        IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
        /// <summary>
        /// Applies access control list (ACL) entries described by a IFileSecurityWrap object to the file described by the current IFileInfoWrap object. 
        /// </summary>
        /// <param name="fileSecurity">A IFileSecurityWrap object that describes an access control list (ACL) entry to apply to the current file.</param>
        void SetAccessControl(IFileSecurityWrap fileSecurity);
        /// <summary>
        /// Returns the path as a string.
        /// </summary>
        /// <returns>A string representing the path.</returns>
        string ToString();
    }
}