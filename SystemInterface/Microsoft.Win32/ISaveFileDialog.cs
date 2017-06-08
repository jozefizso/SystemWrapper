using Microsoft.Win32;
using System.Security;
using SystemInterface.IO;

namespace SystemInterface.Microsoft.Win32
{
    public interface ISaveFileDialog : IFileDialog, IWrapper<SaveFileDialog>
    {
        //
        // Summary:
        //     Gets or sets a value indicating whether Microsoft.Win32.SaveFileDialog prompts
        //     the user for permission to create a file if the user specifies a file that does
        //     not exist.
        //
        // Returns:
        //     true if dialog should prompt prior to saving to a filename that did not previously
        //     exist; otherwise, false. The default is false.
        bool CreatePrompt { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether Microsoft.Win32.SaveFileDialog displays
        //     a warning if the user specifies the name of a file that already exists.
        //
        // Returns:
        //     true if dialog should prompt prior to saving over a filename that previously
        //     existed; otherwise, false. The default is true.
        bool OverwritePrompt { get; set; }

        //
        // Summary:
        //     Creates a read-write file stream for the filename selected by the user using
        //     Microsoft.Win32.SaveFileDialog.
        //
        // Returns:
        //     A new System.IO.Stream that contains the selected file.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     No files were selected in the dialog.
        [SecurityCritical]
        IStream OpenFile();
    }
}
