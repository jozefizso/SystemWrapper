using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SystemInterface;
using SystemInterface.IO;
using SystemInterface.Microsoft.Win32;
using SystemWrapper.IO;

namespace SystemWrapper.Microsoft.Win32
{
    public class SaveFileDialogWrap : ISaveFileDialog
    {

        private readonly SaveFileDialog instance;
        public SaveFileDialogWrap(SaveFileDialog instance)
        {
            this.instance = instance;
            instance.FileOk += Instance_FileOk;
        }

        private void Instance_FileOk(object sender, CancelEventArgs e)
        {
            this.FileOk?.Invoke(sender, e);
        }

        public bool AddExtension
        {
            get
            {
                return instance.AddExtension;
            }

            set
            {
                instance.AddExtension = value;
            }
        }

        public bool CheckFileExists
        {
            get
            {
                return instance.CheckFileExists;
            }

            set
            {
                instance.CheckFileExists = value;
            }
        }

        public bool CheckPathExists
        {
            get
            {
                return instance.CheckPathExists;
            }

            set
            {
                instance.CheckPathExists = value;
            }
        }

        public IList<IFileDialogCustomPlace> CustomPlaces
        {
            get
            {
                return (IList<IFileDialogCustomPlace>)instance.CustomPlaces.Select(s => new FileDialogCustomPlaceWrap(s)).ToList();
            }

            set
            {
                instance.CustomPlaces = value.Select(s => s.Instance).ToList();
            }
        }

        public string DefaultExt
        {
            get
            {
                return instance.DefaultExt;
            }

            set
            {
                instance.DefaultExt = value;
            }
        }

        public bool DereferenceLinks
        {
            get
            {
                return instance.DereferenceLinks;
            }

            set
            {
                instance.DereferenceLinks = value;
            }
        }

        public string FileName
        {
            get
            {
                return instance.FileName;
            }

            set
            {
                instance.FileName = value;
            }
        }

        public string[] FileNames
        {
            get
            {
                return instance.FileNames;
            }
        }

        public string Filter
        {
            get
            {
                return instance.Filter;
            }

            set
            {
                instance.Filter = value;
            }
        }

        public int FilterIndex
        {
            get
            {
                return instance.FilterIndex;
            }

            set
            {
                instance.FilterIndex = value;
            }
        }

        public string InitialDirectory
        {
            get
            {
                return instance.InitialDirectory;
            }

            set
            {
                instance.InitialDirectory = value;
            }
        }

        public bool RestoreDirectory
        {
            get
            {
                return instance.RestoreDirectory;
            }

            set
            {
                instance.RestoreDirectory = value;
            }
        }

        public string SafeFileName
        {
            get
            {
                return instance.SafeFileName;
            }
        }

        public string[] SafeFileNames
        {
            get
            {
                return instance.SafeFileNames;
            }
        }

        public string Title
        {
            get
            {
                return instance.Title;
            }

            set
            {
                instance.Title = value;
            }
        }

        public bool ValidateNames
        {
            get
            {
                return instance.ValidateNames;
            }

            set
            {
                instance.ValidateNames = value;
            }
        }

        public object Tag
        {
            get
            {
                return instance.Tag;
            }

            set
            {
                instance.Tag = value;
            }
        }

        public bool CreatePrompt
        {
            get
            {
                return instance.CreatePrompt;
            }

            set
            {
                instance.CreatePrompt = value;
            }
        }

        public bool OverwritePrompt
        {
            get
            {
                return instance.OverwritePrompt;
            }

            set
            {
                instance.OverwritePrompt = value;
            }
        }

        public SaveFileDialog Instance
        {
            get
            {
                return instance;
            }
        }

        FileDialog IWrapper<FileDialog>.Instance
        {
            get
            {
                return instance;
            }
        }

        CommonDialog IWrapper<CommonDialog>.Instance
        {
            get
            {
                return instance;
            }
        }

        public event CancelEventHandler FileOk;

        public void Reset()
        {
            instance.Reset();
        }

        public bool? ShowDialog()
        {
            return instance.ShowDialog();
        }

        public bool? ShowDialog(Window owner)
        {
            return instance.ShowDialog(owner);
        }

        public IStream OpenFile()
        {
            return new StreamWrap(instance.OpenFile());
        }
    }
}
