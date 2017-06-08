using Microsoft.Win32;
using System.Security;
using SystemInterface.IO;

namespace SystemInterface.Microsoft.Win32
{
    public interface IOpenFileDialog : IWrapper<OpenFileDialog>, IFileDialog
    {
        //
        // Summary:
        //     Gets or sets an option indicating whether Microsoft.Win32.OpenFileDialog allows
        //     users to select multiple files.
        //
        // Returns:
        //     true if multiple selections are allowed; otherwise, false. The default is false.
        bool Multiselect { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the read-only check box displayed by
        //     Microsoft.Win32.OpenFileDialog is selected.
        //
        // Returns:
        //     true if the checkbox is selected; otherwise, false. The default is false.
        bool ReadOnlyChecked { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether Microsoft.Win32.OpenFileDialog contains
        //     a read-only check box.
        //
        // Returns:
        //     true if the checkbox is displayed; otherwise, false. The default is false.
        bool ShowReadOnly { get; set; }

        //
        // Summary:
        //     Opens a read-only stream for the file that is selected by the user using Microsoft.Win32.OpenFileDialog.
        //
        // Returns:
        //     A new System.IO.Stream that contains the selected file.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     No files were selected in the dialog.
        [SecurityCritical]
        IStream OpenFile();
        //
        // Summary:
        //     Creates an array that contains one read-only stream for each file selected by
        //     the user using Microsoft.Win32.OpenFileDialog.
        //
        // Returns:
        //     An array of multiple new System.IO.Stream objects that contain the selected files.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     No files were selected in the dialog.
        [SecurityCritical]
        IStream[] OpenFiles();
    }
}
