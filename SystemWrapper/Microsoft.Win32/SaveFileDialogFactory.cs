using Microsoft.Win32;
using SystemInterface.Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public class SaveFileDialogFactory : ISaveFileDialogFactory
    {
        public ISaveFileDialog Create()
        {
            return new SaveFileDialogWrap(new SaveFileDialog());
        }
    }
}
