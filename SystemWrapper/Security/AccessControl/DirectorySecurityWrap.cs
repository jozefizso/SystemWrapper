using System.Security.AccessControl;
using SystemInterface.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.DirectorySecurity"/> class.
    /// </summary>
    public class DirectorySecurityWrap : IDirectorySecurity
    {
        private DirectorySecurity directorySecurity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Security.AccessControl.DirectorySecurityWrap"/> class on the specified path.
        /// </summary>
        /// <param name="directorySecurity">A <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.</param>
        public DirectorySecurityWrap(DirectorySecurity directorySecurity)
        {
            Initialize(directorySecurity);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Security.AccessControl.DirectorySecurityWrap"/> class on the specified path.
        /// </summary>
        /// <param name="dirSecurity">A <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.</param>
        public void Initialize(DirectorySecurity dirSecurity)
        {
            this.directorySecurity = dirSecurity;
        }

        /// <inheritdoc />
        public DirectorySecurity DirectorySecurityInstance
        {
            get { return directorySecurity; }
        }
    }
}