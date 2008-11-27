using System.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.FileSecurity"/> class.
    /// </summary>
    public class FileSecurityWrap : IFileSecurityWrap
    {
        readonly FileSecurity _fileSecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Security.AccessControl.FileSecurityWrap"/> class on the specified path. 
        /// </summary>
        /// <param name="fileSecurity">A FileSecurity object.</param>
        public FileSecurityWrap(FileSecurity fileSecurity)
        {
            _fileSecurity = fileSecurity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Security.AccessControl.FileSecurityWrap"/> class on the specified path. 
        /// </summary>
        public FileSecurityWrap()
        {
            _fileSecurity = new FileSecurity();
        }

        public FileSecurity FileSecurityInstance
        {
            get { return _fileSecurity; }
        }
    }
}