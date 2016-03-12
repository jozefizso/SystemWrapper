using System;
using SystemInterface;

namespace SystemWrapper
{
    /// <summary>
    /// Provides information about, and means to manipulate, the current environment and platform.
    /// </summary>
    /// <remarks>
    /// This class provides default implementation using the <see cref="Environment"/> static class.
    /// </remarks>
    public class EnvironmentWrap : IEnvironment
    {
        public string CommandLine
        {
            get { return Environment.CommandLine; }
        }

        public string CurrentDirectory
        {
            get
            {
                return Environment.CurrentDirectory;
            }

            set
            {
                Environment.CurrentDirectory = value;
            }
        }

#if NET45

        public int CurrentManagedThreadId
        {
            get { return Environment.CurrentManagedThreadId; }
        }

#endif

        public int ExitCode
        {
            get
            {
                return Environment.ExitCode;
            }

            set
            {
                Environment.ExitCode = value;
            }
        }

        public bool HasShutdownStarted
        {
            get { return Environment.HasShutdownStarted; }
        }

        public bool Is64BitOperatingSystem
        {
            get { return Environment.Is64BitOperatingSystem; }
        }

        public bool Is64BitProcess
        {
            get { return Environment.Is64BitProcess; }
        }

        public string MachineName
        {
            get { return Environment.MachineName; }
        }

        public string NewLine
        {
            get { return Environment.NewLine; }
        }

        public OperatingSystem OSVersion
        {
            get { return Environment.OSVersion; }
        }

        public int ProcessorCount
        {
            get { return Environment.ProcessorCount; }
        }

        public string StackTrace
        {
            get { return Environment.StackTrace; }
        }

        public string SystemDirectory
        {
            get { return Environment.SystemDirectory; }
        }

        public int SystemPageSize
        {
            get { return Environment.SystemPageSize; }
        }

        public int TickCount
        {
            get { return Environment.TickCount; }
        }

        public string UserDomainName
        {
            get { return Environment.UserDomainName; }
        }

        public bool UserInteractive
        {
            get { return Environment.UserInteractive; }
        }

        public string UserName
        {
            get { return Environment.UserName; }
        }

        public IVersion Version
        {
            get { return new VersionWrap(Environment.Version); }
        }

        public long WorkingSet
        {
            get { return Environment.WorkingSet; }
        }
    }
}
