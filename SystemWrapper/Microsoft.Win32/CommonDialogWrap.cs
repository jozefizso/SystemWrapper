using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using SystemInterface.Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public class CommonDialogWrap : ICommonDialog
    {

        private readonly CommonDialog instance;
        public CommonDialogWrap(CommonDialog instance)
        {
            this.instance = instance;
        }

        public CommonDialog Instance
        {
            get
            {
                return instance;
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
    }
}
