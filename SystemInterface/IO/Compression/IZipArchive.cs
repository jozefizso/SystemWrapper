﻿using System;
using System.Collections.ObjectModel;
using MicrosoftImpl = System.IO.Compression;

namespace SystemInterface.IO.Compression
{
    public interface IZipArchive : IDisposable, IWrapper<MicrosoftImpl.ZipArchive>
    {

        ReadOnlyCollection<IZipArchiveEntry> Entries { get; }

        MicrosoftImpl.ZipArchiveMode Mode { get; }


        IZipArchiveEntry CreateEntry(string entryName);

        IZipArchiveEntry CreateEntry(string entryName, MicrosoftImpl.CompressionLevel compressionLevel);

        IZipArchiveEntry GetEntry(string entryName);
    }
}