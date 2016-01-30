namespace SystemWrapper.Net.Mail
{
    using System.Net.Mail;

    using SystemInterface.Net.Mail;

    /// <summary>
    /// Represents an e-mail message that can be sent using the System.Net.Mail.SmtpClient class.
    /// </summary>
    public class MailMessageWrap : IMailMessage
    {
        #region Fields

        private readonly MailMessage mailMessage;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes an empty instance of the System.Net.Mail.MailMessage class.
        /// </summary>
        public MailMessageWrap()
        {
            this.mailMessage = new MailMessage();

            this.BccAddressCollection = new MailAddressCollectionWrap();
            this.CcAddressCollection = new MailAddressCollectionWrap();
            this.ToAddressCollection = new MailAddressCollectionWrap();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the address collection that contains the blind carbon copy (BCC) recipients for this e-mail message.
        /// </summary>
        public IMailAddressCollection Bcc
        {
            get
            {
                return this.BccAddressCollection;
            }
        }

        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        public string Body
        {
            get
            {
                return this.mailMessage.Body;
            }
            set
            {
                this.mailMessage.Body = value;
            }
        }

        /// <summary>
        /// Gets the address collection that contains the carbon copy (CC) recipients for this e-mail message.
        /// </summary>
// ReSharper disable once InconsistentNaming
        public IMailAddressCollection CC
        {
            get
            {
                return this.CcAddressCollection;
            }
        }

        /// <summary>
        /// Gets or sets the from address for this e-mail message.
        /// </summary>
        public IMailAddress From
        {
            get
            {
                return new MailAddressWrap(this.mailMessage.From);
            }
            set
            {
                this.mailMessage.From = new MailAddress(value.Address, value.DisplayName);
            }
        }

        /// <summary>
        /// Gets or sets the subject line for this e-mail message.
        /// </summary>
        public string Subject
        {
            get
            {
                return this.mailMessage.Subject;
            }
            set
            {
                this.mailMessage.Subject = value;
            }
        }

        /// <summary>
        /// Gets the address collection that contains the recipients of this e-mail message.
        /// </summary>
        public IMailAddressCollection To
        {
            get
            {
                return this.ToAddressCollection;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        protected IMailAddressCollection BccAddressCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected IMailAddressCollection CcAddressCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected MailAddressCollectionWrap ToAddressCollection { get; set; }

        #endregion
    }
}