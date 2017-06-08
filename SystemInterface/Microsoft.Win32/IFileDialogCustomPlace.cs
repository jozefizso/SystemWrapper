using Microsoft.Win32;
using System;

namespace SystemInterface.Microsoft.Win32
{
    public interface IFileDialogCustomPlace : IWrapper<FileDialogCustomPlace>
    {
        //
        // Summary:
        //     Gets the GUID of the known folder for the custom place.
        //
        // Returns:
        //     The GUID of a known folder.
        Guid KnownFolder { get; }

        //
        // Summary:
        //     Gets the file path for the custom place.
        //
        // Returns:
        //     The path for a custom place.
        string Path { get; }
    }
}
