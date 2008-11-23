using System.IO;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileInfo"/> class.
    /// </summary>
    public class FileInfoWrap : FileSystemInfo, IFileInfoWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileInfo">A <see cref="T:System.IO.FileInfo"/> object.</param>
        public FileInfoWrap(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.IO.FileInfoWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileName">The fully qualified name of the new file, or the relative file name.</param>
        public FileInfoWrap(string fileName)
        {
            FileInfo = new FileInfo(fileName);
        }

        public override bool Exists
        {
            get { return FileInfo.Exists; }
        }

        public override void Delete()
        {
            FileInfo.Delete();
        }

        public FileInfo FileInfo { get; private set; }

        public override string Name
        {
            get { return FileInfo.Name; }
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