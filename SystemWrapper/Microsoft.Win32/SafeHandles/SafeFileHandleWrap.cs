using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace SystemWrapper.Microsoft.Win32.SafeHandles
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> class.
    /// </summary>
    [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode=true)]
    public class SafeFileHandleWrap : ISafeFileHandleWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Microsoft.Win32.SafeHandles.SafeFileHandleWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="safeFileHandle">A <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> object.</param>
		public SafeFileHandleWrap(SafeFileHandle safeFileHandle)
		{
			Initialize(safeFileHandle);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Microsoft.Win32.SafeHandles.SafeFileHandleWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="safeFileHandle">A <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle"/> object.</param>
		public void Initialize(SafeFileHandle safeFileHandle)
		{
			SafeFileHandleInstance = safeFileHandle;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Microsoft.Win32.SafeHandles.SafeFileHandleWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="preexistingHandle">An IntPtr object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle"> true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
		public SafeFileHandleWrap(IntPtr preexistingHandle, bool ownsHandle)
		{
			Initialize(preexistingHandle, ownsHandle);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Microsoft.Win32.SafeHandles.SafeFileHandleWrap"/> class on the specified path. 
		/// </summary>
		/// <param name="preexistingHandle">An IntPtr object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle"> true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
		public void Initialize(IntPtr preexistingHandle, bool ownsHandle)
		{
			SafeFileHandleInstance = new SafeFileHandle(preexistingHandle, ownsHandle);
		}

		#endregion Constructors and Initializers

		public bool IsClosed
        {
            get { return SafeFileHandleInstance.IsClosed; }
        }

        public bool IsInvalid
        {
            get { return SafeFileHandleInstance.IsInvalid; }
        }

        public SafeFileHandle SafeFileHandleInstance { get; private set; }

        public void Close()
        {
            SafeFileHandleInstance.Close();
        }

        public void DangerousAddRef(ref bool success)
        {
            SafeFileHandleInstance.DangerousAddRef(ref success);
        }

        public IntPtr DangerousGetHandle()
        {
            return SafeFileHandleInstance.DangerousGetHandle();
        }

        public void DangerousRelease()
        {
            SafeFileHandleInstance.DangerousRelease();
        }

        public void SetHandleAsInvalid()
        {
            SafeFileHandleInstance.SetHandleAsInvalid();
        }
    }
}