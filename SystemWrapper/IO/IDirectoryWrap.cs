using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    public interface IDirectoryWrap
    {
        IDirectoryInfoWrap CreateDirectory(string path);
        IDirectoryInfoWrap CreateDirectory(string path, IDirectorySecurityWrap directorySecurity); // Test
        void Delete(string path);

        bool Exists(string path); // Test

        /*
                public static void Delete(string path, bool recursive);
                internal static void Delete(string fullPath, string userPath, bool recursive);
                private static void DeleteHelper(string fullPath, string userPath, bool recursive);
                public static DirectorySecurity GetAccessControl(string path);
                public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections);
                public static DateTime GetCreationTime(string path);
                public static DateTime GetCreationTimeUtc(string path);
                public static string GetCurrentDirectory();
                internal static string GetDemandDir(string fullPath, bool thisDirOnly);
                public static string[] GetDirectories(string path);
                public static string[] GetDirectories(string path, string searchPattern);
                public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
                public static string GetDirectoryRoot(string path);
                public static string[] GetFiles(string path);
                public static string[] GetFiles(string path, string searchPattern);
                public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
                public static string[] GetFileSystemEntries(string path);
                public static string[] GetFileSystemEntries(string path, string searchPattern);
                private static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
                public static DateTime GetLastAccessTime(string path);
                public static DateTime GetLastAccessTimeUtc(string path);
                public static DateTime GetLastWriteTime(string path);
                public static DateTime GetLastWriteTimeUtc(string path);
                public static string[] GetLogicalDrives();
                public static DirectoryInfo GetParent(string path);
                internal static void InternalCreateDirectory(string fullPath, string path, DirectorySecurity dirSecurity);
                internal static bool InternalExists(string path);
                internal static string InternalGetDirectoryRoot(string path);
                internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption);
                public static void Move(string sourceDirName, string destDirName);
                private static SafeFileHandle OpenHandle(string path);
                public static void SetAccessControl(string path, DirectorySecurity directorySecurity);
                public static void SetCreationTime(string path, DateTime creationTime);
                public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
                public static void SetCurrentDirectory(string path);
                public static void SetLastAccessTime(string path, DateTime lastAccessTime);
                public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
                public static void SetLastWriteTime(string path, DateTime lastWriteTime);
                public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);

        */

    }
}