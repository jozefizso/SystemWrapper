using NUnit.Framework;
using System.IO;
using System.IO.Compression;
using SystemInterface.IO.Compression;
using SystemWrapper.IO.Compression;

namespace SystemWrapper.Tests.IO.Compression
{
    [TestFixture]
    internal class ZipFileExtensionsTests
    {
        private const string ArchiveFileName = "archiveFileName.zip";
        private const string FileName = "test.txt";
        private const string ExtractionDir = "extracted";
        private IZipFile mZipFile;

        [SetUp]
        public void SetUp()
        {
            mZipFile = new ZipFileWrap();
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(ArchiveFileName);
            File.Delete(FileName);
            Directory.Delete(ExtractionDir, true);
        }

        [Test]
        public void CreateEntryFromFile_ShouldCreateZipArchiveWithFile()
        {
            File.WriteAllLines(FileName, new[] { "this is the only line" });

            using (IZipArchive newZipArchive = mZipFile.Open(ArchiveFileName, ZipArchiveMode.Create))
            {
                newZipArchive.CreateEntryFromFile(FileName, FileName);
            }

            using (IZipArchive zipArchive = mZipFile.OpenRead(ArchiveFileName))
            {
                Assert.AreEqual(1, zipArchive.Entries.Count);
            }
        }

        [TestCase(CompressionLevel.NoCompression)]
        [TestCase(CompressionLevel.Fastest)]
        [TestCase(CompressionLevel.Optimal)]
        public void CreateEntryFromFile_CompressionLevel_ShouldCreateZipArchiveWithFile(CompressionLevel level)
        {
            File.WriteAllLines(FileName, new[] { "this is the only line" });

            using (IZipArchive newZipArchive = mZipFile.Open(ArchiveFileName, ZipArchiveMode.Create))
            {
                newZipArchive.CreateEntryFromFile(FileName, FileName, level);
            }

            using (IZipArchive zipArchive = mZipFile.OpenRead(ArchiveFileName))
            {
                Assert.AreEqual(1, zipArchive.Entries.Count);
            }
        }

        [Test]
        public void ExtractToDirectory_ShouldExtractFileToDirectory()
        {
            File.WriteAllLines(FileName, new[] { "this is the only line" });

            using (IZipArchive newZipArchive = mZipFile.Open(ArchiveFileName, ZipArchiveMode.Create))
            {
                newZipArchive.CreateEntryFromFile(FileName, FileName);

                //Test sanity check
                Assert.IsFalse(Directory.Exists(ExtractionDir));
            }

            using (IZipArchive zipArchive = mZipFile.OpenRead(ArchiveFileName))
            {
                zipArchive.ExtractToDirectory(ExtractionDir);

                Assert.IsTrue(Directory.Exists(ExtractionDir));
                Assert.IsTrue(Directory.GetFiles(ExtractionDir)[0].Contains(FileName));
            }
        }
    }
}
