namespace SystemWrapper.Net.Mail
{
    using System;
    using System.Net.Mail;
    using System.Text;

    using SystemInterface.Attributes;
    using SystemInterface.Net.Mail;

    /// <summary>
    /// Represents the address of an electronic mail sender or recipient.
    /// </summary>
    [GenerateFactory(typeof(IMailAddressFactory))]
    public class MailAddressWrap : IMailAddress
    {
        #region Fields

        private readonly MailAddress mailAddress;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the System.Net.Mail.MailAddress class using the specified address.
        /// </summary>
        /// <param name="address">
        /// A System.String that contains an e-mail address.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// address is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// address is System.String.Empty ("").
        /// </exception>
        /// <exception cref="FormatException">
        /// address is not in a recognized format.
        /// </exception>
        public MailAddressWrap(string address)
        {
            this.mailAddress = new MailAddress(address);
        }

        /// <summary>
        /// Initializes a new instance of the System.Net.Mail.MailAddress class using the specified address, and display name.
        /// </summary>
        /// <param name="address">
        /// A System.String that contains an e-mail address.
        /// </param>
        /// <param name="displayName">
        /// A System.String that contains the display name associated with address.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// address is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// address is System.String.Empty ("").
        /// </exception>
        /// <exception cref="FormatException">
        /// address is not in a recognized format.-or-address contains non-ASCII characters.
        /// </exception>
        public MailAddressWrap(string address,
                               string displayName)
        {
            this.mailAddress = new MailAddress(address, displayName);
        }

        /// <summary>
        /// Initializes a new instance of the System.Net.Mail.MailAddress class using the specified address, display name, and encoding.
        /// </summary>
        /// <param name="address">
        /// A System.String that contains an e-mail address.
        /// </param>
        /// <param name="displayName">
        /// A System.String that contains the display name associated with address.
        /// </param>
        /// <param name="encoding">
        /// The System.Text.Encoding that defines the character set used for displayName.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// address is null.-or-displayName is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// address is System.String.Empty ("").-or-displayName is System.String.Empty ("").
        /// </exception>
        /// <exception cref="FormatException">
        /// address is not in a recognized format.-or-address contains non-ASCII characters.
        /// </exception>
        public MailAddressWrap(string address,
                               string displayName,
                               Encoding encoding)
        {
            this.mailAddress = new MailAddress(address, displayName, encoding);
        }

        /// <summary>
        /// Initializes a new instance of the MailAddressWrap with the MailAddress.
        /// </summary>
        /// <param name="address">
        /// the mailAdress.
        /// </param>
        public MailAddressWrap(MailAddress address)
        {
            this.mailAddress = address;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the e-mail address specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the e-mail address.
        /// </returns>
        public string Address
        {
            get
            {
                return this.mailAddress.Address;
            }
        }

        /// <summary>
        /// Gets the display name composed from the display name and address information specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the display name; otherwise, System.String.Empty ("") if no display name information was specified when this instance was created.
        /// </returns>
        public string DisplayName
        {
            get
            {
                return this.mailAddress.DisplayName;
            }
        }

        /// <summary>
        /// Gets the host portion of the address specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the name of the host computer that accepts e-mail for the System.Net.Mail.MailAddress.User property.
        /// </returns>
        public string Host
        {
            get
            {
                return this.mailAddress.Host;
            }
        }

        /// <summary>
        /// Gets the user information from the address specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the user name portion of the System.Net.Mail.MailAddress.Address.
        /// </returns>
        public string User
        {
            get
            {
                return this.mailAddress.User;
            }
        }

        #endregion
    }
}