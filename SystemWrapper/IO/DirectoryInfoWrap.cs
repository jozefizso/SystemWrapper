using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
	/// <summary>
	/// Wrapper for <see cref="T:System.IO.DirectoryInfo"/> class.
	/// </summary>
	[Serializable, ComVisible(true)]
	public class DirectoryInfoWrap : IDirectoryInfoWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="directoryInfo">A <see cref="T:System.IO.DirectoryInfo"/> object.</param>
		public DirectoryInfoWrap(DirectoryInfo directoryInfo)
		{
			Initialize(directoryInfo);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="directoryInfo">A <see cref="T:System.IO.DirectoryInfo"/> object.</param>
		public void Initialize(DirectoryInfo directoryInfo)
		{
			DirectoryInfo = directoryInfo;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="path">A string specifying the path on which to create the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/>. </param>
		public DirectoryInfoWrap(string path)
		{
			Initialize(path);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="path">A string specifying the path on which to create the <see cref="T:SystemWrapper.IO.DirectoryInfoWrap"/>. </param>
		public void Initialize(string path)
		{
			DirectoryInfo = new DirectoryInfo(path);
		}

		#endregion
		
		public FileAttributes Attributes
		{
			get { return DirectoryInfo.Attributes; }
			set { DirectoryInfo.Attributes = value; }
		}

		public IDateTimeWrap CreationTime
		{
			get { return new DateTimeWrap(DirectoryInfo.CreationTime); }
			set { DirectoryInfo.CreationTime = value.DateTimeInstance; }
		}

		public IDateTimeWrap CreationTimeUtc
		{
			get { return new DateTimeWrap(DirectoryInfo.CreationTimeUtc); }
			set { DirectoryInfo.CreationTimeUtc = value.DateTimeInstance; }
		}

		public DirectoryInfo DirectoryInfo { get; private set; }

		public bool Exists
		{
			get { return DirectoryInfo.Exists; }
		}

		public string Extension
		{
			get { return DirectoryInfo.Extension; }
		}

		public string FullName
		{
			get { return DirectoryInfo.FullName; }
		}

		public IDateTimeWrap LastAccessTime
		{
			get { return new DateTimeWrap(DirectoryInfo.LastAccessTime); }
			set { DirectoryInfo.LastAccessTime = value.DateTimeInstance; }
		}

		public IDateTimeWrap LastAccessTimeUtc
		{
			get { return new DateTimeWrap(DirectoryInfo.LastAccessTimeUtc); }
			set { DirectoryInfo.LastAccessTimeUtc = value.DateTimeInstance; }
		}

		public IDateTimeWrap LastWriteTime
		{
			get { return new DateTimeWrap(DirectoryInfo.LastWriteTime); }
			set { DirectoryInfo.LastWriteTime = value.DateTimeInstance; }
		}

		public IDateTimeWrap LastWriteTimeUtc
		{
			get { return new DateTimeWrap(DirectoryInfo.LastWriteTimeUtc); }
			set { DirectoryInfo.LastWriteTimeUtc = value.DateTimeInstance; }
		}

		public string Name
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
			DirectoryInfo.Create(directorySecurity.DirectorySecurityInstance);
		}

		public ObjRef CreateObjRef(Type requestedType)
		{
			return DirectoryInfo.CreateObjRef(requestedType);
		}

		public IDirectoryInfoWrap CreateSubdirectory(string path)
		{
			return new DirectoryInfoWrap(DirectoryInfo.CreateSubdirectory(path));
		}

		public IDirectoryInfoWrap CreateSubdirectory(string path, IDirectorySecurityWrap directorySecurity)
		{
			return new DirectoryInfoWrap(DirectoryInfo.CreateSubdirectory(path, directorySecurity.DirectorySecurityInstance));
		}

		public void Delete()
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

		public object GetLifetimeService()
		{
			return DirectoryInfo.GetLifetimeService();
		}

		public object InitializeLifetimeService()
		{
			return DirectoryInfo.InitializeLifetimeService();
		}

		public void MoveTo(string destDirName)
		{
			DirectoryInfo.MoveTo(destDirName);
		}

		public void Refresh()
		{
			DirectoryInfo.Refresh();
		}

		public void SetAccessControl(IDirectorySecurityWrap directorySecurity)
		{
			DirectoryInfo.SetAccessControl(directorySecurity.DirectorySecurityInstance);
		}

		public override string ToString()
		{
			return DirectoryInfo.ToString();
		}

		private static IDirectoryInfoWrap[] ConvertDirectoryInfoArrayIntoIDirectoryInfoWrapArray(DirectoryInfo[] directoryInfos)
		{
			IDirectoryInfoWrap[] directoryInfoWraps = new DirectoryInfoWrap[directoryInfos.Length];
			for (int i = 0; i < directoryInfos.Length; i++)
				directoryInfoWraps[i] = new DirectoryInfoWrap(directoryInfos[i]);
			return directoryInfoWraps;
		}
	}
}