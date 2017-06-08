using Microsoft.Win32;
using SystemInterface.Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public class OpenFileDialogFactory : IOpenFileDialogFactory
    {
        public IOpenFileDialog Create()
        {
            return new OpenFileDialogWrap(new OpenFileDialog());
        }
    }
}
