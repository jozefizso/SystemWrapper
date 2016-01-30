namespace SystemInterface.Net.Mail
{
    using System;
    using System.Text;

    /// <summary>
    ///   Defines the contract for MailAdress class.
    /// </summary>    
    public interface IMailAddressFactory
    {
        #region Public Methods and Operators

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
        IMailAddress Create(string address);

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
        IMailAddress Create(string address,
                            string displayName);

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
        IMailAddress Create(string address,
                            string displayName,
                            Encoding encoding);

        #endregion
    }
}