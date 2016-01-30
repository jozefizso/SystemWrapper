namespace SystemWrapper.ActiveDirectory
{
    using System.DirectoryServices.AccountManagement;

    using SystemWrapper.ActiveDirectory.Contracts;

    /// <summary>
    /// 
    /// </summary>
    public class PrincipalContextWrap : IPrincipalContext
    {
        #region Fields

        private readonly PrincipalContext principalContext;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contextType"></param>
        /// <param name="name"></param>
        public PrincipalContextWrap(ContextType contextType,
                                    string name)
        {
            this.principalContext = new PrincipalContext(contextType, name);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>
        public PrincipalContext PrincipalContextInstance
        {
            get
            {
                return this.principalContext;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.principalContext.Dispose();
        }

        #endregion
    }
}