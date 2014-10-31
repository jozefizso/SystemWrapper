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
        public bool Is64BitOperatingSystem
        {
            get
            {
                return Environment.Is64BitOperatingSystem;
            }
        }

        public bool Is64BitProcess
        {
            get
            {
                return Environment.Is64BitProcess;
            }
        }
    }
}
