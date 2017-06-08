using Microsoft.Win32;
using System;
using SystemInterface.Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public class FileDialogCustomPlaceFactory : IFileDialogCustomPlaceFactory
    {
        public IFileDialogCustomPlace Create(string path)
        {
            return new FileDialogCustomPlaceWrap(new FileDialogCustomPlace(path));
        }

        public IFileDialogCustomPlace Create(Guid knownFolder)
        {
            return new FileDialogCustomPlaceWrap(new FileDialogCustomPlace(knownFolder));
        }
    }
}
