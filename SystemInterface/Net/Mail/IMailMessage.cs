namespace SystemInterface.Net.Mail
{
    /// <summary>
    ///   Defines the contract for MailMessage class.
    /// </summary>
    public interface IMailMessage
    {
        #region Public Properties

        /// <summary>
        /// Gets the address collection that contains the blind carbon copy (BCC) recipients for this e-mail message.
        /// </summary>
        IMailAddressCollection Bcc { get; }

        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        string Body { get; set; }

        /// <summary>
        /// Gets the address collection that contains the carbon copy (CC) recipients for this e-mail message.
        /// </summary>
// ReSharper disable once InconsistentNaming
        IMailAddressCollection CC { get; }

        /// <summary>
        /// Gets or sets the from address for this e-mail message.
        /// </summary>
        IMailAddress From { get; set; }

        /// <summary>
        /// Gets or sets the subject line for this e-mail message.
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// Gets the address collection that contains the recipients of this e-mail message.
        /// </summary>
        IMailAddressCollection To { get; }

        #endregion
    }
}