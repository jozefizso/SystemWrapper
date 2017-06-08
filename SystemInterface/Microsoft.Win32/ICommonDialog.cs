using Microsoft.Win32;
using System.Security;
using System.Windows;

namespace SystemInterface.Microsoft.Win32
{
    public interface ICommonDialog : IWrapper<CommonDialog>
    {
        //
        // Summary:
        //     Gets or sets an object associated with the dialog. This provides the ability
        //     to attach an arbitrary object to the dialog.
        //
        // Returns:
        //     A System.Object that is attached or associated with a dialog.
        object Tag { get; set; }

        //
        // Summary:
        //     When overridden in a derived class, resets the properties of a common dialog
        //     to their default values.
        [SecurityCritical]
        void Reset();
        //
        // Summary:
        //     Displays a common dialog.
        //
        // Returns:
        //     If the user clicks the OK button of the dialog that is displayed (e.g. Microsoft.Win32.OpenFileDialog,
        //     Microsoft.Win32.SaveFileDialog), true is returned; otherwise, false.
        [SecurityCritical]
        bool? ShowDialog();
        //
        // Summary:
        //     Displays a common dialog.
        //
        // Parameters:
        //   owner:
        //     Handle to the window that owns the dialog.
        //
        // Returns:
        //     If the user clicks the OK button of the dialog that is displayed (e.g. Microsoft.Win32.OpenFileDialog,
        //     Microsoft.Win32.SaveFileDialog), true is returned; otherwise, false.
        [SecurityCritical]
        bool? ShowDialog(Window owner);
    }
}
