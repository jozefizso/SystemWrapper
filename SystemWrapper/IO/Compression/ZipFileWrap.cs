﻿using System.Text;
using SystemInterface.IO.Compression;
using MicrosoftImpl = System.IO.Compression;

namespace SystemWrapper.IO.Compression
{
    public class ZipFileWrap : IZipFile
    {
        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName)
        {
            MicrosoftImpl.ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName);
        }

        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, MicrosoftImpl.CompressionLevel compressionLevel, bool includeBaseDirectory)
        {
            MicrosoftImpl.ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, compressionLevel, includeBaseDirectory);
        }

        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, MicrosoftImpl.CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            MicrosoftImpl.ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName, compressionLevel, includeBaseDirectory, entryNameEncoding);
        }

        public void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName)
        {
            MicrosoftImpl.ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
        }

        public void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding)
        {
            MicrosoftImpl.ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName, entryNameEncoding);
        }

        public IZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode)
        {
            return new ZipArchiveWrap(MicrosoftImpl.ZipFile.Open(archiveFileName, mode));
        }

        public IZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode, Encoding entryNameEncoding)
        {
            return new ZipArchiveWrap(MicrosoftImpl.ZipFile.Open(archiveFileName, mode));
        }

        public IZipArchive OpenRead(string archiveFileName)
        {
            return new ZipArchiveWrap(MicrosoftImpl.ZipFile.OpenRead(archiveFileName));
        }
    }
}