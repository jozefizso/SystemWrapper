using System.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.FileSecurity"/> class.
    /// </summary>
    public interface IFileSecurityWrap
    {
        /// <summary>
        /// Gets <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.
        /// </summary>
        FileSecurity FileSecurityInstance { get; }
    }
}