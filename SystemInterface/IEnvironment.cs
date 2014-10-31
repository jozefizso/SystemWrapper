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
        /// Gets or sets the exit code of the process.
        /// </summary>
        /// <value>
        /// A 32-bit signed integer containing the exit code. The default value
        /// is 0 (zero), which indicates that the process completed successfully.
        /// </value>
        /// <remarks>
        /// <para>If the Main method returns void, you can use this property to set the exit
        ///   code that will be returned to the calling environment. If Main does not
        ///   return void, this property is ignored. The initial value of this
        ///   property is zero.</para>
        /// <para>Use a non-zero number to indicate an error. In your application,
        ///   you can define your own error codes in an enumeration, and return
        ///   the appropriate error code based on the scenario. For example, return
        ///   a value of 1 to indicate that the required file is not present and
        ///   a value of 2 to indicate that the file is in the wrong format.
        ///   For a list of exit codes used by the Windows operating system,
        ///   see System Error Codes in the Windows documentation.</para>
        /// </remarks>
        int ExitCode { get; set; }

        /// <summary>
        /// Gets a value that indicates whether the current application
        /// domain is being unloaded or the common language runtime
        /// (CLR) is shutting down.
        /// </summary>
        /// <value>
        /// true if the current application domain is being unloaded or the CLR is shutting down; otherwise, false.
        /// </value>
        /// <remarks>
        /// <para>When the CLR unloads an application domain, it runs the finalizers on all objects
        ///   that have a finalizer method in that application domain. When the CLR shuts down, it starts
        ///   the finalizer thread on all objects that have a finalizer method. The HasShutdownStarted
        ///   property returns true only after the finalizer thread has been started. When the property
        ///   returns true, you can determine whether an application domain is being unloaded or the CLR
        ///   itself is shutting down by calling the <see cref="AppDomain.IsFinalizingForUnload"/> method.
        ///   This method returns true if finalizers are called because the application domain is unloading
        ///   or false if the CLR is shutting down.</para>
        /// <para>The HasShutdownStarted property returns false if the finalizer thread has not been started.</para>
        /// <para>By using this property, you can determine whether to access static variables in your
        ///   finalization code. If either an application domain or the CLR is shutting down, you
        ///   cannot reliably access any object that has a finalization method and that is referenced
        ///   by a static field. This is because these objects may have already been finalized.</para>
        /// </remarks>
        bool HasShutdownStarted { get; }

        /// <summary>
        /// Determines whether the current operating system is a 64-bit operating system.
        /// </summary>
        /// <value>
        /// true if the operating system is 64-bit; otherwise, false.
        /// </value>
        bool Is64BitOperatingSystem { get; }

        /// <summary>
        /// Determines whether the current process is a 64-bit process.
        /// </summary>
        /// <value>
        /// true if the process is 64-bit; otherwise, false.
        /// </value>
        bool Is64BitProcess { get; }

        /// <summary>
        /// Gets the NetBIOS name of this local computer.
        /// </summary>
        /// <value>
        /// A string containing the name of this computer.
        /// </value>
        /// <exception cref="InvalidOperationException">The name of this computer cannot be obtained.</exception>
        /// <remarks>
        /// The name of this computer is established at system startup when the name is read from the registry. If this computer is a node in a cluster, the name of the node is returned.
        /// </remarks>
        /// <permission cref="EnvironmentPermission">
        /// For read access to the COMPUTERNAME environment variable. Associated enumeration: <see cref="EnvironmentPermissionAccess.Read"/>.
        /// </permission>
        string MachineName { get; }
    }
}
