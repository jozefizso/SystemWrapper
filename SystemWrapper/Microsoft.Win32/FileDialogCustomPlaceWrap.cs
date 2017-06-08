using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using SystemInterface.Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public class FileDialogCustomPlaceWrap : IFileDialogCustomPlace
    {

        private readonly FileDialogCustomPlace instance;
        public FileDialogCustomPlaceWrap(FileDialogCustomPlace instance)
        {
            this.instance = instance;
        }

        public FileDialogCustomPlace Instance
        {
            get
            {
                return instance;
            }
        }

        public Guid KnownFolder
        {
            get
            {
                return instance.KnownFolder;
            }
        }

        public string Path
        {
            get
            {
                return instance.Path;
            }
        }
    }
}
