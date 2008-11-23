using System.IO;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
    /// </summary>
    public interface IFileInfoWrap
    {
        // Properties

        /// <summary>
        /// Gets a value indicating whether a file exists. 
        /// </summary>
        bool Exists { get; }
        /// <summary>
        /// Gets <see cref="T:System.IO.FileInfo"/> object.
        /// </summary>
        FileInfo FileInfo { get; }
        /// <summary>
        /// Gets the name of the file. 
        /// </summary>
        string Name { get; }

        // Methods

        /// <summary>
        /// Permanently deletes a file.
        /// </summary>
        void Delete();
        /*
                public DirectoryInfo Directory { get; }
                public string DirectoryName { get; }
                public bool IsReadOnly { get; set; }
                public long Length { get; }

            public FileInfo(string fileName);
            public StreamWriter AppendText();
            public FileInfo CopyTo(string destFileName);
            public FileInfo CopyTo(string destFileName, bool overwrite);
            public FileStream Create();
            public StreamWriter CreateText();
            [ComVisible(false)]
            public void Decrypt();
            [ComVisible(false)]
            public void Encrypt();
            public FileSecurity GetAccessControl();
            public FileSecurity GetAccessControl(AccessControlSections includeSections);
            public void MoveTo(string destFileName);
            public FileStream Open(FileMode mode);
            public FileStream Open(FileMode mode, FileAccess access);
            public FileStream Open(FileMode mode, FileAccess access, FileShare share);
            public FileStream OpenRead();
            public StreamReader OpenText();
            public FileStream OpenWrite();
            [ComVisible(false)]
            public FileInfo Replace(string destinationFileName, string destinationBackupFileName);
            [ComVisible(false)]
            public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
            public void SetAccessControl(FileSecurity fileSecurity);
            public override string ToString();
        */

    }
}