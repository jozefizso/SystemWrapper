using System.IO.Compression;
using SystemInterface.IO.Compression;

namespace SystemWrapper.IO.Compression
{
    public static class ZipFileExtensions
    {
        public static IZipArchiveEntry CreateEntryFromFile(this IZipArchive destination, string sourceFileName, string entryName)
        {
            return new ZipArchiveEntryWrap(destination.Instance.CreateEntryFromFile(sourceFileName, entryName));
        }

        public static IZipArchiveEntry CreateEntryFromFile(this IZipArchive destination, string sourceFileName, string entryName, CompressionLevel compressionLevel)
        {
            return new ZipArchiveEntryWrap(destination.Instance.CreateEntryFromFile(sourceFileName, entryName, compressionLevel));
        }
    }
}
