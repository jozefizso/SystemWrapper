using System.IO;

namespace SystemWrapper.IO
{
	/// <summary>
    /// Wrapper for <see cref="T:System.IO.MemoryStream"/> class.
    /// </summary>
	public interface IMemoryStreamWrap : IStreamWrap
	{
        // Properties

        /// <summary>
        /// Gets or sets the number of bytes allocated for this stream. 
        /// </summary>
        int Capacity { get; set; }
        /// <summary>
        /// Gets <see cref="T:System.IO.MemoryStream"/> object.
        /// </summary>
        MemoryStream MemoryStreamInstance { get; }

        // Methods

        /// <summary>
        /// Returns the array of unsigned bytes from which this stream was created. 
        /// </summary>
        /// <returns>The byte array from which this stream was created, or the underlying array if a byte array was not provided to the MemoryStream constructor during construction of the current instance.</returns>
        byte[] GetBuffer();
        /// <summary>
        /// Writes the stream contents to a byte array, regardless of the Position property. 
        /// </summary>
        /// <returns>A new byte array.</returns>
        byte[] ToArray();
        /// <summary>
        /// Writes the entire contents of this memory stream to another stream. 
        /// </summary>
        /// <param name="stream">The stream to write this memory stream to.</param>
        void WriteTo(IStreamWrap stream);

	}
}
