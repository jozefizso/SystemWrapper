using System;
using System.Collections.ObjectModel;
using System.IO.Compression;
using System.Linq;
using SystemInterface.IO.Compression;

namespace SystemWrapper.IO.Compression
{
    public class ZipArchiveWrap : IZipArchive
    {
        public ZipArchive Instance { get; private set; }

        public ZipArchiveWrap(ZipArchive instance)
        {
            this.Instance = instance;
        }

        public ReadOnlyCollection<IZipArchiveEntry> Entries
        {
            get
            {
                return new ReadOnlyCollection<IZipArchiveEntry>(Instance.Entries.Select(s => new ZipArchiveEntryWrap(s)).Cast<IZipArchiveEntry>().ToList());
            }
        }

        public ZipArchiveMode Mode
        {
            get
            {
                return Instance.Mode;
            }
        }

        public IZipArchiveEntry CreateEntry(string entryName)
        {
            return new ZipArchiveEntryWrap(Instance.CreateEntry(entryName));
        }

        public IZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel)
        {
            return new ZipArchiveEntryWrap(Instance.CreateEntry(entryName, compressionLevel));
        }

        public IZipArchiveEntry GetEntry(string entryName)
        {
            return new ZipArchiveEntryWrap(Instance.GetEntry(entryName));
        }

        public void Dispose()
        {
            Instance.Dispose();
        }
    }
}
