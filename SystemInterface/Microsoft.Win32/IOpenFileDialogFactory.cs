using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInterface.Microsoft.Win32
{
    public interface IOpenFileDialogFactory
    {
        IOpenFileDialog Create();
    }
}
