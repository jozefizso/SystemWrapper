using System;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace SystemInterface
{
    /// <summary>
    /// Provides information about, and means to manipulate, the current environment and platform.
    /// </summary>
    /// <remarks>
    /// This interface represents the <see cref="Environment"/> class.
    /// </remarks>
    public interface IEnvironment
    {
        /// <summary>
        /// Gets the command line for this process.
        /// </summary>
        /// <value>
        /// A string containing command-line arguments.
        /// </value>
        /// <remarks>
        /// <para>This property provides access to the program name and any arguments specified
        ///   on the command line when the current process was started.</para>
        /// <para>The program name can include path information, but is not required to do so.
        ///   Use the GetCommandLineArgs method to retrieve the command-line information parsed
        ///   and stored in an array of strings.</para>
        /// <para>The maximum size of the command-line buffer is not set to a specific number
        ///   of characters; it varies depending on the Windows operating system that is running
        ///   on the computer.</para>
        /// </remarks>
        /// <permission cref="EnvironmentPermission">
        /// For read access to the PATH environment variable. Associated enumeration: <see cref="EnvironmentPermissionAccess.Read"/>.
        /// </permission>
        string CommandLine { get; }

        /// <summary>
        /// Gets or sets the fully qualified path of the current working directory.
        /// </summary>
        /// <value>
        /// A string containing a directory path.
        /// </value>
        /// <remarks>
        /// By definition, if this process starts in the root directory of a local or network drive,
        /// the value of this property is the drive name followed by a trailing slash
        /// (for example, "C:\"). If this process starts in a subdirectory, the value of this property
        /// is the drive and subdirectory path, without a trailing slash (for example, "C:\mySubDirectory").
        /// </remarks>
        /// <exception cref="ArgumentException">Attempted to set to an empty string ("").</exception>
        /// <exception cref="ArgumentNullException">Attempted to set to null.</exception>
        /// <exception cref="IOException">An I/O error occurred.</exception>
        /// <exception cref="DirectoryNotFoundException">Attempted to set a local path that cannot be found.</exception>
        /// <exception cref="SecurityException">The caller does not have the appropriate permission.</exception>
        /// <permission cref="SecurityPermission">
        /// For writing to files or directories in a set operation. Associated enumeration: <see cref="SecurityPermissionFlag.UnmanagedCode"/>.
        /// </permission>
        /// <permission cref="FileIOPermission">
        /// For access to the information in the path itself in a get operation. Associated enumeration: <see cref="FileIOPermissionAccess.PathDiscovery"/>.
        /// </permission>
        string CurrentDirectory { get; set; }

        /// <summary>
        /// Gets a unique identifier for the current managed thread.
        /// </summary>
        /// <value>
        /// An integer that represents a unique identifier for this managed thread.
        /// </value>
        int CurrentManagedThreadId { get; }

        /// <summary>
        /// Determines whether the current operating system is a 64-bit operating system.
        /// </summary>
        /// <returns>
        /// true if the operating system is 64-bit; otherwise, false.
        /// </returns>
        bool Is64BitOperatingSystem { get; }

        /// <summary>
        /// Determines whether the current process is a 64-bit process.
        /// </summary>
        /// <returns>
        /// true if the process is 64-bit; otherwise, false.
        /// </returns>
        bool Is64BitProcess { get; }
    }
}
