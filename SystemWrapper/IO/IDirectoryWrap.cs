using System.IO;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="System.IO.Directory"/> class.
    /// </summary>
    public interface IDirectoryWrap
    {
        /// <summary>
        /// Creates all directories and subdirectories as specified by path. 
        /// </summary>
        /// <param name="path">The directory path to create.</param>
        /// <returns>A <see cref="T:SystemWrapper.IO.IDirectoryWrap"/> as specified by path.</returns>
        /// <exception cref="T:System.IO.IOException">
        /// The directory specified by <paramref name="path"/> is read-only. 
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        /// The caller does not have the required permission. 
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="path"/> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.
        /// -or-
        /// <paramref name="path"/> is prefixed with, or contains only a colon character (:). 
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="path"/> is null.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        /// The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// The specified path is invalid (for example, it is on an unmapped drive). 
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// <paramref name="path"/> contains a colon character (:) that is not part of a drive label ("C:\"). 
        /// </exception>
        IDirectoryInfoWrap CreateDirectory(string path);
        /// <summary>
        /// Creates all the directories in the specified path, applying the specified Windows security. 
        /// </summary>
        /// <param name="path">The directory to create.</param>
        /// <param name="directorySecurity">The access control to apply to the directory.</param>
        /// <returns>A <see cref="T:SystemWrapper.IO.IDirectoryWrap"/> object representing the newly created directory. </returns>
        IDirectoryInfoWrap CreateDirectory(string path, IDirectorySecurityWrap directorySecurity);
        /// <summary>
        /// Deletes an empty directory from a specified path. 
        /// </summary>
        /// <param name="path">The name of the empty directory to remove. This directory must be writable or empty. </param>
        void Delete(string path);
        /// <summary>
        /// Deletes the specified directory and, if indicated, any subdirectories in the directory. 
        /// </summary>
        /// <param name="path">The name of the directory to remove.</param>
        /// <param name="recursive">true to remove directories, subdirectories, and files in path; otherwise, false.</param>
        void Delete(string path, bool recursive);
        /// <summary>
        /// Determines whether the given path refers to an existing directory on disk. 
        /// </summary>
        /// <param name="path">The path to test. </param>
        /// <returns>true if <param name="path"> refers to an existing directory; otherwise, false.</returns>
        bool Exists(string path);
        /// <summary>
        /// Gets a <see cref="T:SystemWrapper.Security.AccessControl.IDirectorySecurityWrap"/> object that encapsulates the access control list (ACL) entries for a specified directory. 
        /// </summary>
        /// <param name="path">The path to a directory containing a <see cref="DirectorySecurity"/> object that describes the file's access control list (ACL) information. </param>
        /// <returns>A <see cref="T:SystemWrapper.Security.AccessControl.IDirectorySecurityWrap"/> object that encapsulates the access control rules for the file described by the <param name="path"> parameter. </returns>
        IDirectorySecurityWrap GetAccessControl(string path);
        /// <summary>
        /// Gets a <see cref="T:SystemWrapper.Security.AccessControl.IDirectorySecurityWrap"/> object that encapsulates the access control list (ACL) entries for a specified directory. 
        /// </summary>
        /// <param name="path">The path to a directory containing a <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object that describes the file's access control list (ACL) information. </param>
        /// <param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections"/> values that specifies the type of access control list (ACL) information to receive. </param>
        /// <returns></returns>
        IDirectorySecurityWrap GetAccessControl(string path, AccessControlSections includeSections);
        /// <summary>
        /// Gets the creation date and time of a directory. 
        /// </summary>
        /// <param name="path">The path of the directory. </param>
        /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in local time. </returns>
        IDateTimeWrap GetCreationTime(string path);
        /// <summary>
        /// Gets the creation date and time, in Coordinated Universal Time (UTC) format, of a directory. 
        /// </summary>
        /// <param name="path">The path of the directory. </param>
        /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in UTC time. </returns>
        IDateTimeWrap GetCreationTimeUtc(string path);
        /// <summary>
        /// Gets the current working directory of the application. 
        /// </summary>
        /// <returns>A string containing the path of the current working directory.</returns>
        string GetCurrentDirectory();
        /// <summary>
        /// Gets the names of subdirectories in the specified directory. 
        /// </summary>
        /// <param name="path">The path for which an array of subdirectory names is returned.</param>
        /// <returns>An array of type String containing the names of subdirectories in <param name="path">.</returns>
        string[] GetDirectories(string path);
        /// <summary>
        /// Gets an array of directories matching the specified search pattern from the current directory. 
        /// </summary>
        /// <param name="path">The path to search. </param>
        /// <param name="searchPattern">The search string to match against the names of files in path. The parameter cannot end in two periods ("..") or contain two periods ("..") followed by DirectorySeparatorChar or AltDirectorySeparatorChar, nor can it contain any of the characters in InvalidPathChars.</param>
        /// <returns>A String array of directories matching the search pattern.</returns>
        string[] GetDirectories(string path, string searchPattern);
        /// <summary>
        /// Gets an array of directories matching the specified search pattern from the current directory, using a value to determine whether to search subdirectories.
        /// </summary>
        /// <param name="path">The path to search. </param>
        /// <param name="searchPattern">The search string to match against the names of files in path. The parameter cannot end in two periods ("..") or contain two periods ("..") followed by DirectorySeparatorChar or AltDirectorySeparatorChar, nor can it contain any of the characters in InvalidPathChars.</param>
        /// <param name="searchOption">One of the SearchOption values that specifies whether the search operation should include all subdirectories or only the current directory. </param>
        /// <returns>A String array of directories matching the search pattern. </returns>
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
        /// <summary>
        /// Returns the volume information, root information, or both for the specified path.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>A string containing the volume information, root information, or both for the specified path.</returns>
        string GetDirectoryRoot(string path);
        /// <summary>
        /// Returns the names of files in the specified directory.
        /// </summary>
        /// <param name="path">The directory from which to retrieve the files. </param>
        /// <returns>A String array of file names in the specified directory. </returns>
        string[] GetFiles(string path);
        /// <summary>
        /// Returns the names of files in the specified directory that match the specified search pattern.
        /// </summary>
        /// <param name="path">The directory to search. </param>
        /// <param name="searchPattern">The search string to match against the names of files in path. The parameter cannot end in two periods ("..") or contain two periods ("..") followed by DirectorySeparatorChar or AltDirectorySeparatorChar, nor can it contain any of the characters in InvalidPathChars.</param>
        /// <returns>A String array containing the names of files in the specified directory that match the specified search pattern.</returns>
        string[] GetFiles(string path, string searchPattern);
        /// <summary>
        /// Returns the names of files in the specified directory that match the specified search pattern, using a value to determine whether to search subdirectories.
        /// </summary>
        /// <param name="path">The directory to search. </param>
        /// <param name="searchPattern">The search string to match against the names of files in path. The parameter cannot end in two periods ("..") or contain two periods ("..") followed by DirectorySeparatorChar or AltDirectorySeparatorChar, nor can it contain any of the characters in InvalidPathChars.</param>
        /// <param name="searchOption">One of the SearchOption values that specifies whether the search operation should include all subdirectories or only the current directory. </param>
        /// <returns>A String array containing the names of files in the specified directory that match the specified search pattern. File names include the full path.</returns>
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
        /// <summary>
        /// Returns the names of all files and subdirectories in the specified directory. 
        /// </summary>
        /// <param name="path">The directory for which file and subdirectory names are returned.</param>
        /// <returns>A String array containing the names of file system entries in the specified directory.</returns>
        string[] GetFileSystemEntries(string path);
        /// <summary>
        /// Returns an array of file system entries matching the specified search criteria.
        /// </summary>
        /// <param name="path">The path to be searched. </param>
        /// <param name="searchPattern">The search string to match against the names of files in path. The searchPattern parameter cannot end in two periods ("..") or contain two periods ("..") followed by DirectorySeparatorChar or AltDirectorySeparatorChar, nor can it contain any of the characters in InvalidPathChars. </param>
        /// <returns>A String array of file system entries matching the search criteria. </returns>
        string[] GetFileSystemEntries(string path, string searchPattern);
        /// <summary>
        /// Returns the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information. </param>
        /// <returns>A IDateTimeWrap set to the date and time the specified file or directory was last accessed. This value is expressed in local time.</returns>
        IDateTimeWrap GetLastAccessTime(string path);
        /// <summary>
        /// Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A IDateTimeWrap set to the date and time the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        IDateTimeWrap GetLastAccessTimeUtc(string path);
        /// <summary>
        /// Returns the date and time the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information. </param>
        /// <returns>A IDateTimeWrap set to the date and time the specified file or directory was last written to. This value is expressed in local time.</returns>
        IDateTimeWrap GetLastWriteTime(string path);
        /// <summary>
        /// Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last written to. 
        /// </summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns>A IDateTimeWrap set to the date and time the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        IDateTimeWrap GetLastWriteTimeUtc(string path);
        /// <summary>
        /// Retrieves the names of the logical drives on this computer in the form "<drive letter>:\". 
        /// </summary>
        /// <returns>The logical drives on this computer.</returns>
        string[] GetLogicalDrives();
        /// <summary>
        /// Retrieves the parent directory of the specified path, including both absolute and relative paths. 
        /// </summary>
        /// <param name="path">The path for which to retrieve the parent directory.</param>
        /// <returns>The parent directory, or nullNothingnullptra null reference (Nothing in Visual Basic) if path is the root directory, including the root of a UNC server or share name.</returns>
        IDirectoryInfoWrap GetParent(string path);
        /// <summary>
        /// Moves a file or a directory and its contents to a new location.
        /// </summary>
        /// <param name="sourceDirName">The path of the file or directory to move.</param>
        /// <param name="destDirName">The path to the new location for <paramref name="sourceDirName"/>. If <paramref name="sourceDirName"/> is a file, then <paramref name="destDirName"/> must also be a file name.</param>
        void Move(string sourceDirName, string destDirName);
        /// <summary>
        /// Applies access control list (ACL) entries described by a <see cref="T:SystemWrapper.IO.IDirectoryWrap"/> object to the specified directory. 
        /// </summary>
        /// <param name="path">A directory to add or remove access control list (ACL) entries from.</param>
        /// <param name="directorySecurity">A <see cref="T:SystemWrapper.IO.IDirectoryWrap"/> object that describes an ACL entry to apply to the directory described by the path parameter.</param>
        void SetAccessControl(string path, IDirectorySecurityWrap directorySecurity);
        /// <summary>
        /// Sets the creation date and time for the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to set the creation date and time information.</param>
        /// <param name="creationTime">A IDateTimeWrap containing the value to set for the creation date and time of path. This value is expressed in local time.</param>
        void SetCreationTime(string path, IDateTimeWrap creationTime);
        /// <summary>
        /// Sets the creation date and time, in Coordinated Universal Time (UTC) format, for the specified file or directory. 
        /// </summary>
        /// <param name="path">The file or directory for which to set the creation date and time information. </param>
        /// <param name="creationTimeUtc">A IDateTimeWrap containing the value to set for the creation date and time of path. This value is expressed in UTC time.</param>
        void SetCreationTimeUtc(string path, IDateTimeWrap creationTimeUtc);
        /// <summary>
        /// Sets the application's current working directory to the specified directory. 
        /// </summary>
        /// <param name="path">The path to which the current working directory is set.</param>
        void SetCurrentDirectory(string path);
        /// <summary>
        /// Sets the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to set the access date and time information. </param>
        /// <param name="lastAccessTime">A IDateTimeWrap containing the value to set for the access date and time of path. This value is expressed in local time.</param>
        void SetLastAccessTime(string path, IDateTimeWrap lastAccessTime);
        /// <summary>
        /// Sets the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">A IDateTimeWrap containing the value to set for the access date and time of path. This value is expressed in UTC time.</param>
        void SetLastAccessTimeUtc(string path, IDateTimeWrap lastAccessTimeUtc);
        /// <summary>
        /// Sets the date and time a directory was last written to.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTime">The date and time the directory was last written to. This value is expressed in local time.</param>
        void SetLastWriteTime(string path, IDateTimeWrap lastWriteTime);
        /// <summary>
        /// Sets the date and time, in Coordinated Universal Time (UTC) format, that a directory was last written to. 
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTimeUtc">The date and time the directory was last written to. This value is expressed in UTC time.</param>
        void SetLastWriteTimeUtc(string path, IDateTimeWrap lastWriteTimeUtc);
    }
}