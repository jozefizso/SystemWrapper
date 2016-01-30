namespace SystemWrapper.Net.Mail
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Mail;

    using SystemInterface.Net.Mail;

    /// <summary>
    /// Store e-mail addresses that are associated with an e-mail message.
    /// </summary>
    public class MailAddressCollectionWrap : IMailAddressCollection
    {
        #region Fields

        private readonly List<IMailAddress> mailAddresses;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes an empty instance of the System.Net.Mail.MailAddressCollection class.
        /// </summary>
        public MailAddressCollectionWrap()
        {
            this.mailAddresses = new List<IMailAddress>();
        }

        /// <summary>
        /// Initializes an instance of the System.Net.Mail.MailAddressCollection class with To as collection.
        /// </summary>
        /// <param name="addressCollection">
        /// </param>
        public MailAddressCollectionWrap(MailAddressCollection addressCollection)
        {
            var mailAddressCollection = addressCollection;

            this.mailAddresses = new List<IMailAddress>();
            foreach (var mailAddress in mailAddressCollection)
            {
                this.mailAddresses.Add(new MailAddressWrap(mailAddress));
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <returns>
        /// The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </returns>
        public int Count
        {
            get
            {
                return this.mailAddresses.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
        /// </summary>
        /// <returns>
        /// true if the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only; otherwise, false.
        /// </returns>
        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }

        #endregion

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
        public void Add(string address)
        {
            this.mailAddresses.Add(new MailAddressWrap(address));
        }

        /// <summary>
        /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        public void Add(IMailAddress item)
        {
            this.mailAddresses.Add(item);
        }

        /// <summary>
        /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only. </exception>
        public void Clear()
        {
            this.mailAddresses.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1"/> contains a specific value.
        /// </summary>
        /// <returns>
        /// true if <paramref name="item"/> is found in the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false.
        /// </returns>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
        public bool Contains(IMailAddress item)
        {
            return this.mailAddresses.Contains(item);
        }

        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1"/> to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional <see cref="T:System.Array"/> that is the destination of the elements copied 
        /// from <see cref="T:System.Collections.Generic.ICollection`1"/>. The <see cref="T:System.Array"/> 
        /// must have zero-based indexing.</param><param name="arrayIndex">The zero-based index in <paramref name="array"/>
        /// at which copying begins.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="arrayIndex"/> is less than 0.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="array"/> is multidimensional.-or-The number of elements in the source 
        /// <see cref="T:System.Collections.Generic.ICollection`1"/> is greater than the available space from 
        /// <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.-or-Type <paramref name="T"/> 
        /// cannot be cast automatically to the type of the destination <paramref name="array"/>.
        /// </exception>
        public void CopyTo(IMailAddress[] array,
                           int arrayIndex)
        {
            this.mailAddresses.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<IMailAddress> GetEnumerator()
        {
            return this.mailAddresses.GetEnumerator();
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </summary>
        /// <returns>
        /// true if <paramref name="item"/> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false. This method also returns false if <paramref name="item"/> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1"/>.
        /// </returns>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.</exception>
        public bool Remove(IMailAddress item)
        {
            return this.mailAddresses.Remove(item);
        }

        /// <summary>
        /// Returns a string representation of the e-mail addresses in this System.Net.Mail.MailAddressCollection object.
        /// </summary>
        /// <returns>
        /// A System.String containing the e-mail addresses in this collection.
        /// </returns>
        public override string ToString()
        {
            return this.mailAddresses.ToString();
        }

        #endregion

        #region Explicit Interface Methods

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion
    }
}