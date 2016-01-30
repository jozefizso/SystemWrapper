namespace SystemInterface.Net.Mail
{
    /// <summary>
    ///   Defines the contract for MailAdress class.
    /// </summary>
    public interface IMailAddress
    {
        #region Public Properties

        /// <summary>
        /// Gets the e-mail address specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the e-mail address.
        /// </returns>
        string Address { get; }

        /// <summary>
        /// Gets the display name composed from the display name and address information specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the display name; otherwise, System.String.Empty ("") if no display name information was specified when this instance was created.
        /// </returns>
        string DisplayName { get; }

        /// <summary>
        /// Gets the host portion of the address specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the name of the host computer that accepts e-mail for the System.Net.Mail.MailAddress.User property.
        /// </returns>
        string Host { get; }

        /// <summary>
        /// Gets the user information from the address specified when this instance was created.
        /// </summary>
        /// <returns>
        /// A System.String that contains the user name portion of the System.Net.Mail.MailAddress.Address.
        /// </returns>
        string User { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Returns a string representation of this instance.
        /// </summary>
        /// <returns>
        /// A System.String that contains the contents of this System.Net.Mail.MailAddress.
        /// </returns>
        string ToString();

        #endregion
    }
}