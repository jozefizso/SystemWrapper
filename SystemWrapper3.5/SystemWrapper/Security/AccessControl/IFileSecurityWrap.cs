using System.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.FileSecurity"/> class.
    /// </summary>
    public interface IFileSecurityWrap
    {
    	/// <summary>
    	/// Initializes a new instance of the <see cref="T:SystemWrapper.Security.AccessControl.FileSecurityWrap"/> class on the specified path. 
    	/// </summary>
    	/// <param name="fileSecurity">A FileSecurity object.</param>
    	void Initialize(FileSecurity fileSecurity);

    	/// <summary>
    	/// Initializes a new instance of the <see cref="T:SystemWrapper.Security.AccessControl.FileSecurityWrap"/> class on the specified path. 
    	/// </summary>
    	void Initialize();


        /// <summary>
        /// Gets <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.
        /// </summary>
        FileSecurity FileSecurityInstance { get; }
    }
}