namespace SystemInterface.Net.Mail
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///   Defines the contract for MailAddressCollection class.
    /// </summary>
    public interface IMailAddressCollection : ICollection<IMailAddress>
    {
        #region Public Methods and Operators

        /// <summary>
        /// Add a list of e-mail addresses to the collection.
        /// </summary>
        /// <param name="address">
        /// The e-mail addresses to add to the MailAddressCollection. Multiple e-mail addresses must be separated with a comma character (",").
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The addresses parameter is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The addresses parameter is an empty string.
        /// </exception>
        /// <exception cref="FormatException">
        /// The addresses parameter contains an e-mail address that is invalid or not supported.
        /// </exception>
        void Add(string address);

        /// <summary>
        /// Returns a string representation of the e-mail addresses in this System.Net.Mail.MailAddressCollection object.
        /// </summary>
        /// <returns>
        /// A System.String containing the e-mail addresses in this collection.
        /// </returns>
        string ToString();

        #endregion
    }
}