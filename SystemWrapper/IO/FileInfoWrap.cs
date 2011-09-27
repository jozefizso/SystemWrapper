using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
	/// </summary>
	[Serializable, ComVisible(true)]
	public class FileInfoWrap : IFileInfoWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
		public FileInfoWrap(FileInfo fileInfo)
		{
			Initialize(fileInfo);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
		public void Initialize(FileInfo fileInfo)
		{
			FileInfoInstance = fileInfo;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
		public FileInfoWrap(string fileName)
		{
			Initialize(fileName);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
		public void Initialize(string fileName)
		{
			FileInfoInstance = new FileInfo(fileName);
		}

		#endregion

        /// <inheritdoc />
        public FileAttributes Attributes
		{
			get { return FileInfoInstance.Attributes; }
			set { FileInfoInstance.Attributes = value; }
		}

        /// <inheritdoc />
        public IDateTimeWrap CreationTime
		{
			get { return new DateTimeWrap(FileInfoInstance.CreationTime); }
			set { FileInfoInstance.CreationTime = value.DateTimeInstance; }
		}

        /// <inheritdoc />
        public IDateTimeWrap CreationTimeUtc
		{
			get { return new DateTimeWrap(FileInfoInstance.CreationTimeUtc); }
			set { FileInfoInstance.CreationTimeUtc = value.DateTimeInstance; }
		}

        /// <inheritdoc />
        public IDirectoryInfoWrap Directory
		{
			get { return new DirectoryInfoWrap(FileInfoInstance.Directory); }
		}

        /// <inheritdoc />
        public string DirectoryName
		{
			get { return FileInfoInstance.DirectoryName; }
		}

        /// <inheritdoc />
        public bool Exists
		{
			get { return FileInfoInstance.Exists; }
		}

        /// <inheritdoc />
        public string Extension
		{
			get { return FileInfoInstance.Extension; }
		}

        /// <inheritdoc />
        public FileInfo FileInfoInstance { get; private set; }

        /// <inheritdoc />
        public string FullName
		{
			get { return FileInfoInstance.FullName; }
		}

        /// <inheritdoc />
        public bool IsReadOnly
		{
			get { return FileInfoInstance.IsReadOnly; }
			set { FileInfoInstance.IsReadOnly = value; }
		}

        /// <inheritdoc />
        public IDateTimeWrap LastAccessTime
		{
			get { return new DateTimeWrap(FileInfoInstance.LastAccessTime); }
			set { FileInfoInstance.LastAccessTime = value.DateTimeInstance; }
		}

        /// <inheritdoc />
        public IDateTimeWrap LastAccessTimeUtc
		{
			get { return new DateTimeWrap(FileInfoInstance.LastAccessTimeUtc); }
			set { FileInfoInstance.LastAccessTimeUtc = value.DateTimeInstance; }
		}

        /// <inheritdoc />
        public IDateTimeWrap LastWriteTime
		{
			get { return new DateTimeWrap(FileInfoInstance.LastWriteTime); }
			set { FileInfoInstance.LastWriteTime = value.DateTimeInstance; }
		}

        /// <inheritdoc />
        public IDateTimeWrap LastWriteTimeUtc
		{
			get { return new DateTimeWrap(FileInfoInstance.LastWriteTimeUtc); }
			set { FileInfoInstance.LastWriteTimeUtc = value.DateTimeInstance; }
		}

        /// <inheritdoc />
        public long Length
		{
			get { return FileInfoInstance.Length; }
		}

        /// <inheritdoc />
        public string Name
		{
			get { return FileInfoInstance.Name; }
		}

        /// <inheritdoc />
        public IStreamWriterWrap AppendText()
		{
			return new StreamWriterWrap(FileInfoInstance.AppendText());
		}

        /// <inheritdoc />
        public void Decrypt()
		{
			FileInfoInstance.Decrypt();
		}

        /// <inheritdoc />
        public void Delete()
		{
			FileInfoInstance.Delete();
		}

        /// <inheritdoc />
        public void Encrypt()
		{
			FileInfoInstance.Encrypt();
		}

        /// <inheritdoc />
        public IFileInfoWrap CopyTo(string destFileName)
		{
			return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName));
		}

        /// <inheritdoc />
        public IFileInfoWrap CopyTo(string destFileName, bool overwrite)
		{
			return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName, overwrite));
		}

        /// <inheritdoc />
        public IFileStreamWrap Create()
		{
			return new FileStreamWrap(FileInfoInstance.Create());
		}

        /// <inheritdoc />
        public IStreamWriterWrap CreateText()
		{
			return new StreamWriterWrap(FileInfoInstance.CreateText());
		}

        /// <inheritdoc />
        public IFileSecurityWrap GetAccessControl()
		{
			return new FileSecurityWrap(FileInfoInstance.GetAccessControl());
		}

        /// <inheritdoc />
        public IFileSecurityWrap GetAccessControl(AccessControlSections includeSections)
		{
			return new FileSecurityWrap(FileInfoInstance.GetAccessControl(includeSections));
		}

        /// <inheritdoc />
        public void MoveTo(string destFileName)
		{
			FileInfoInstance.MoveTo(destFileName);
		}

        /// <inheritdoc />
        public IFileStreamWrap Open(FileMode mode)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode));
		}

        /// <inheritdoc />
        public IFileStreamWrap Open(FileMode mode, FileAccess access)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode, access));
		}

        /// <inheritdoc />
        public IFileStreamWrap Open(FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode, access, share));
		}

        /// <inheritdoc />
        public IFileStreamWrap OpenRead()
		{
			return new FileStreamWrap(FileInfoInstance.OpenRead());
		}

        /// <inheritdoc />
        public IStreamReaderWrap OpenText()
		{
			return new StreamReaderWrap(FileInfoInstance.OpenText());
		}

        /// <inheritdoc />
        public IFileStreamWrap OpenWrite()
		{
			return new FileStreamWrap(FileInfoInstance.OpenWrite());
		}

        /// <inheritdoc />
        public void Refresh()
		{
			FileInfoInstance.Refresh();
		}

        /// <inheritdoc />
        public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName)
		{
			return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName));
		}

        /// <inheritdoc />
        public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
		}

        /// <inheritdoc />
        public void SetAccessControl(IFileSecurityWrap fileSecurity)
		{
			FileInfoInstance.SetAccessControl(fileSecurity.FileSecurityInstance);
		}

        /// <inheritdoc />
        public override string ToString()
		{
			return FileInfoInstance.ToString();
		}

		internal static IFileInfoWrap[] ConvertFileInfoArrayIntoIFileInfoWrapArray(FileInfo[] fileInfos)
		{
			var fileInfoWraps = new FileInfoWrap[fileInfos.Length];
			for (int i = 0; i < fileInfos.Length; i++)
				fileInfoWraps[i] = new FileInfoWrap(fileInfos[i]);
			return fileInfoWraps;
		}
	}
}