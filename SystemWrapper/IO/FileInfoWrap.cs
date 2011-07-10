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

		public FileAttributes Attributes
		{
			get { return FileInfoInstance.Attributes; }
			set { FileInfoInstance.Attributes = value; }
		}

		public IDateTimeWrap CreationTime
		{
			get { return new DateTimeWrap(FileInfoInstance.CreationTime); }
			set { FileInfoInstance.CreationTime = value.DateTimeInstance; }
		}

		public IDateTimeWrap CreationTimeUtc
		{
			get { return new DateTimeWrap(FileInfoInstance.CreationTimeUtc); }
			set { FileInfoInstance.CreationTimeUtc = value.DateTimeInstance; }
		}

		public IDirectoryInfoWrap Directory
		{
			get { return new DirectoryInfoWrap(FileInfoInstance.Directory); }
		}

		public string DirectoryName
		{
			get { return FileInfoInstance.DirectoryName; }
		}

		public bool Exists
		{
			get { return FileInfoInstance.Exists; }
		}

		public string Extension
		{
			get { return FileInfoInstance.Extension; }
		}

		public FileInfo FileInfoInstance { get; private set; }

		public string FullName
		{
			get { return FileInfoInstance.FullName; }
		}

		public bool IsReadOnly
		{
			get { return FileInfoInstance.IsReadOnly; }
			set { FileInfoInstance.IsReadOnly = value; }
		}

		public IDateTimeWrap LastAccessTime
		{
			get { return new DateTimeWrap(FileInfoInstance.LastAccessTime); }
			set { FileInfoInstance.LastAccessTime = value.DateTimeInstance; }
		}

		public IDateTimeWrap LastAccessTimeUtc
		{
			get { return new DateTimeWrap(FileInfoInstance.LastAccessTimeUtc); }
			set { FileInfoInstance.LastAccessTimeUtc = value.DateTimeInstance; }
		}

		public IDateTimeWrap LastWriteTime
		{
			get { return new DateTimeWrap(FileInfoInstance.LastWriteTime); }
			set { FileInfoInstance.LastWriteTime = value.DateTimeInstance; }
		}

		public IDateTimeWrap LastWriteTimeUtc
		{
			get { return new DateTimeWrap(FileInfoInstance.LastWriteTimeUtc); }
			set { FileInfoInstance.LastWriteTimeUtc = value.DateTimeInstance; }
		}

		public long Length
		{
			get { return FileInfoInstance.Length; }
		}

		public string Name
		{
			get { return FileInfoInstance.Name; }
		}

		public IStreamWriterWrap AppendText()
		{
			return new StreamWriterWrap(FileInfoInstance.AppendText());
		}

		public void Decrypt()
		{
			FileInfoInstance.Decrypt();
		}

		public void Delete()
		{
			FileInfoInstance.Delete();
		}

		public void Encrypt()
		{
			FileInfoInstance.Encrypt();
		}

		public IFileInfoWrap CopyTo(string destFileName)
		{
			return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName));
		}

		public IFileInfoWrap CopyTo(string destFileName, bool overwrite)
		{
			return new FileInfoWrap(FileInfoInstance.CopyTo(destFileName, overwrite));
		}

		public IFileStreamWrap Create()
		{
			return new FileStreamWrap(FileInfoInstance.Create());
		}

		public IStreamWriterWrap CreateText()
		{
			return new StreamWriterWrap(FileInfoInstance.CreateText());
		}

		public IFileSecurityWrap GetAccessControl()
		{
			return new FileSecurityWrap(FileInfoInstance.GetAccessControl());
		}

		public IFileSecurityWrap GetAccessControl(AccessControlSections includeSections)
		{
			return new FileSecurityWrap(FileInfoInstance.GetAccessControl(includeSections));
		}

		public void MoveTo(string destFileName)
		{
			FileInfoInstance.MoveTo(destFileName);
		}

		public IFileStreamWrap Open(FileMode mode)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode));
		}

		public IFileStreamWrap Open(FileMode mode, FileAccess access)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode, access));
		}

		public IFileStreamWrap Open(FileMode mode, FileAccess access, FileShare share)
		{
			return new FileStreamWrap(FileInfoInstance.Open(mode, access, share));
		}

		public IFileStreamWrap OpenRead()
		{
			return new FileStreamWrap(FileInfoInstance.OpenRead());
		}

		public IStreamReaderWrap OpenText()
		{
			return new StreamReaderWrap(FileInfoInstance.OpenText());
		}

		public IFileStreamWrap OpenWrite()
		{
			return new FileStreamWrap(FileInfoInstance.OpenWrite());
		}

		public void Refresh()
		{
			FileInfoInstance.Refresh();
		}

		public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName)
		{
			return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName));
		}

		public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			return new FileInfoWrap(FileInfoInstance.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
		}

		public void SetAccessControl(IFileSecurityWrap fileSecurity)
		{
			FileInfoInstance.SetAccessControl(fileSecurity.FileSecurityInstance);
		}

		public override string ToString()
		{
			return FileInfoInstance.ToString();
		}

		internal static IFileInfoWrap[] ConvertFileInfoArrayIntoIFileInfoWrapArray(FileInfo[] fileInfos)
		{
			FileInfoWrap[] fileInfoWraps = new FileInfoWrap[fileInfos.Length];
			for (int i = 0; i < fileInfos.Length; i++)
				fileInfoWraps[i] = new FileInfoWrap(fileInfos[i]);
			return fileInfoWraps;
		}
	}
}