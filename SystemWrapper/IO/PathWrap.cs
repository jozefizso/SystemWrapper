using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.Path"/> class.
    /// </summary>
    [Serializable, ComVisible(true)]
    public class PathWrap : IPathWrap
    {
        public char AltDirectorySeparatorChar
        {
            get { return Path.AltDirectorySeparatorChar; }
        }

        public char DirectorySeparatorChar
        {
            get { return Path.DirectorySeparatorChar; }
        }

        public char PathSeparator
        {
            get { return Path.PathSeparator; }
        }

        public char VolumeSeparatorChar
        {
            get { return Path.VolumeSeparatorChar; }
        }

        public string ChangeExtension(string path, string extension)
        {
            return Path.ChangeExtension(path, extension);
        }

        public string Combine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }

        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }

        public char[] GetInvalidFileNameChars()
        {
            return Path.GetInvalidFileNameChars();
        }

        public char[] GetInvalidPathChars()
        {
            return Path.GetInvalidPathChars();
        }

        public string GetPathRoot(string path)
        {
            return Path.GetPathRoot(path);
        }

        public string GetRandomFileName()
        {
            return Path.GetRandomFileName();
        }

        public string GetTempFileName()
        {
            return Path.GetTempFileName();
        }

        public string GetTempPath()
        {
            return Path.GetTempPath();
        }

        public bool HasExtension(string path)
        {
            return Path.HasExtension(path);
        }

        public bool IsPathRooted(string path)
        {
            return Path.IsPathRooted(path);
        }
    }
}