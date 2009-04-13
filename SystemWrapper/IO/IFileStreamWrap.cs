using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using SystemWrapper.Microsoft.Win32.SafeHandles;
using SystemWrapper.Security.AccessControl;

namespace SystemWrapper.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.FileStream"/> class.
    /// </summary>
    public interface IFileStreamWrap : IStreamWrap
    {
        // Properties

        /// <summary>
        /// Gets <see cref="T:System.IO.FileStream"/> object.
        /// </summary>
        FileStream FileStreamInstance { get; }
        /// <summary>
        /// Gets a value indicating whether the FileStream was opened asynchronously or synchronously.
        /// </summary>
        bool IsAsync { get; }
        /// <summary>
        /// Gets the name of the IFileStreamWrap that was passed to the constructor.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets a ISafeFileHandleWrap object that represents the operating system file handle for the file that the current FileStream object encapsulates. 
        /// </summary>
        ISafeFileHandleWrap SafeFileHandle { [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode), SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get; }

         // Methods

        /// <summary>
        /// Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream.
        /// </summary>
//        void Close();

        /// <summary>
        /// Gets a IFileSecurityWrap object that encapsulates the access control list (ACL) entries for the file described by the current FileStream object. 
        /// </summary>
        /// <returns>A IFileSecurityWrap object that encapsulates the access control settings for the file described by the current FileStream object. </returns>
        IFileSecurityWrap GetAccessControl();
        /// <summary>
        /// Prevents other processes from changing the FileStream while permitting read access. 
        /// </summary>
        /// <param name="position">The beginning of the range to lock. The value of this parameter must be equal to or greater than zero (0). </param>
        /// <param name="length">The range to be locked. </param>
        void Lock(long position, long length);
        /// <summary>
        /// Applies access control list (ACL) entries described by a IFileSecurityWrap object to the file described by the current FileStream object. 
        /// </summary>
        /// <param name="fileSecurity">A IFileSecurityWrap object that describes an ACL entry to apply to the current file.</param>
        void SetAccessControl(IFileSecurityWrap fileSecurity);
        /// <summary>
        /// Returns a String that represents the current Object. 
        /// </summary>
        /// <returns>A String that represents the current Object. </returns>
        string ToString();
        /// <summary>
        /// Allows access by other processes to all or part of a file that was previously locked.
        /// </summary>
        /// <param name="position">The beginning of the range to unlock.</param>
        /// <param name="length">The range to be unlocked.</param>
        void Unlock(long position, long length);
    }
}