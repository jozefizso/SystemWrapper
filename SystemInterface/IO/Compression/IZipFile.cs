using System.Text;
using MicrosoftImpl = System.IO.Compression;

namespace SystemInterface.IO.Compression {
	public interface IZipFile : IStaticWrapper {
		void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName);
		void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, MicrosoftImpl.CompressionLevel compressionLevel, bool includeBaseDirectory);
		void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, MicrosoftImpl.CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding);
		void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName);
		void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding);
		IZipArchive Open(string archiveFileName, MicrosoftImpl.ZipArchiveMode mode);
		IZipArchive Open(string archiveFileName, MicrosoftImpl.ZipArchiveMode mode, Encoding entryNameEncoding);
		IZipArchive OpenRead(string archiveFileName);
	}
}
