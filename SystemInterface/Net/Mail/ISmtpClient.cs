namespace SystemInterface.Net.Mail
{
    using System;
    using System.Net.Mail;

    /// <summary>
    ///   Defines the contract for SmtpClient class.
    /// </summary>
    public interface ISmtpClient
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the name or IP address of the host used for SMTP transactions.
        /// </summary>
        string Host { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Sends the specified message to an SMTP server for delivery.
        /// </summary>
        /// <param name="mailMessage">
        /// A System.Net.Mail.MailMessage that contains the message to send.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// This System.Net.Mail.SmtpClient has a Overload:System.Net.Mail.SmtpClient.SendAsync call in progress.-or- System.Net.Mail.MailMessage.From is null.-or- There are no recipients specified in System.Net.Mail.MailMessage.To, System.Net.Mail.MailMessage.CC, and System.Net.Mail.MailMessage.Bcc properties.-or- System.Net.Mail.SmtpClient.DeliveryMethod property is set to System.Net.Mail.SmtpDeliveryMethod.Network and System.Net.Mail.SmtpClient.Host is null.-or-System.Net.Mail.SmtpClient.DeliveryMethod property is set to System.Net.Mail.SmtpDeliveryMethod.Network and System.Net.Mail.SmtpClient.Host is equal to the empty string ("").-or- System.Net.Mail.SmtpClient.DeliveryMethod property is set to System.Net.Mail.SmtpDeliveryMethod.Network and System.Net.Mail.SmtpClient.Port is zero, a negative number, or greater than 65,535.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been disposed.
        /// </exception>
        /// <exception cref="SmtpException">
        /// The connection to the SMTP server failed.-or-Authentication failed.-or-The operation timed out.-or-System.Net.Mail.SmtpClient.EnableSsl is set to true but the System.Net.Mail.SmtpClient.DeliveryMethod property is set to System.Net.Mail.SmtpDeliveryMethod.SpecifiedPickupDirectory or System.Net.Mail.SmtpDeliveryMethod.PickupDirectoryFromIis.-or-System.Net.Mail.SmtpClient.EnableSsl is set to true, but the SMTP mail server did not advertise STARTTLS in the response to the EHLO command.
        /// </exception>
        /// /// <exception cref="SmtpFailedRecipientsException">
        /// The message could not be delivered to one or more of the recipients in System.Net.Mail.MailMessage.To, System.Net.Mail.MailMessage.CC, or System.Net.Mail.MailMessage.Bcc.
        /// </exception>        
        void Send(IMailMessage mailMessage);

        #endregion
    }
}