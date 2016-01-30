#pragma warning disable 1591

namespace SystemWrapper.Net.Mail
{
    using System;
    using System.Net.Mail;
    using System.Text;

    using SystemInterface.Attributes;
    using SystemInterface.Net.Mail;

    /// <summary>
    /// The implementation for the factory generating <see cref="SystemWrapper.Net.Mail.MailAddressWrap" /> instances.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("DeveloperInTheFlow.FactoryGenerator", "1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public partial class MailAddressWrapFactory : SystemInterface.Net.Mail.IMailAddressFactory
    {
        #region Public Factory Methods

        public SystemInterface.Net.Mail.IMailAddress Create(string address)
        {
            return new SystemWrapper.Net.Mail.MailAddressWrap(address);
        }

        public SystemInterface.Net.Mail.IMailAddress Create(
            string address,
            string displayName)
        {
            return new SystemWrapper.Net.Mail.MailAddressWrap(
                address, 
                displayName);
        }

        public SystemInterface.Net.Mail.IMailAddress Create(
            string address,
            string displayName,
            System.Text.Encoding encoding)
        {
            return new SystemWrapper.Net.Mail.MailAddressWrap(
                address, 
                displayName, 
                encoding);
        }

        #endregion
    }
}