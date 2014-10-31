using System;
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
