using System;

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
