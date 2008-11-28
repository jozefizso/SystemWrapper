using System;
using Microsoft.Win32.SafeHandles;

namespace SystemWrapper.Microsoft.Win32.SafeHandles
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> class.
    /// </summary>
    public interface ISafeFileHandleWrap
    {
        // Properties

        /// <summary>
        /// Gets a value indicating whether the handle is closed.
        /// </summary>
        bool IsClosed { get; }
        /// <summary>
        /// Gets a value that indicates whether the handle is invalid.
        /// </summary>
        bool IsInvalid { get; }
        /// <summary>
        /// Gets <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> object.
        /// </summary>
        SafeFileHandle SafeFileHandleInstance { get; }
        
        // Methods

        /// <summary>
        /// Marks the handle for releasing and freeing resources.
        /// </summary>
        void Close();
        /// <summary>
        /// Manually increments the reference counter on SafeHandle instances.
        /// </summary>
        /// <param name="success">true if the reference counter was successfully incremented; otherwise, false.</param>
        void DangerousAddRef(ref bool success);
        /// <summary>
        /// Returns the value of the handle field. 
        /// </summary>
        /// <returns></returns>
        IntPtr DangerousGetHandle();
        /// <summary>
        /// Manually decrements the reference counter on a SafeHandle instance.
        /// </summary>
        void DangerousRelease();
        /// <summary>
        /// Marks a handle as no longer used.
        /// </summary>
        void SetHandleAsInvalid();
    }
}