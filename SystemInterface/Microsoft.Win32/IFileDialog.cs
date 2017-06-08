using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;

namespace SystemInterface.Microsoft.Win32
{
    public interface IFileDialog : IWrapper<FileDialog>, ICommonDialog
    {

        //
        // Summary:
        //     Gets or sets a value indicating whether a file dialog automatically adds an extension
        //     to a file name if the user omits an extension.
        //
        // Returns:
        //     true if extensions are added; otherwise, false. The default is true.
        bool AddExtension { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether a file dialog displays a warning if the
        //     user specifies a file name that does not exist.
        //
        // Returns:
        //     true if warnings are displayed; otherwise, false. The default in this base class
        //     is false.
        bool CheckFileExists { get; set; }
        //
        // Summary:
        //     Gets or sets a value that specifies whether warnings are displayed if the user
        //     types invalid paths and file names.
        //
        // Returns:
        //     true if warnings are displayed; otherwise, false. The default is true.
        bool CheckPathExists { get; set; }
        //
        // Summary:
        //     Gets or sets the list of custom places for file dialog boxes.
        //
        // Returns:
        //     The list of custom places.
        IList<IFileDialogCustomPlace> CustomPlaces { get; set; }
        //
        // Summary:
        //     Gets or sets a value that specifies the default extension string to use to filter
        //     the list of files that are displayed.
        //
        // Returns:
        //     The default extension string. The default is System.String.Empty.
        string DefaultExt { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether a file dialog returns either the location
        //     of the file referenced by a shortcut or the location of the shortcut file (.lnk).
        //
        // Returns:
        //     true to return the location referenced; false to return the shortcut location.
        //     The default is false.
        bool DereferenceLinks { get; set; }
        //
        // Summary:
        //     Gets or sets a string containing the full path of the file selected in a file
        //     dialog.
        //
        // Returns:
        //     A System.String that is the full path of the file selected in the file dialog.
        //     The default is System.String.Empty.
        string FileName { get; set; }
        //
        // Summary:
        //     Gets an array that contains one file name for each selected file.
        //
        // Returns:
        //     An array of System.String that contains one file name for each selected file.
        //     The default is an array with a single item whose value is System.String.Empty.
        string[] FileNames { get; }
        //
        // Summary:
        //     Gets or sets the filter string that determines what types of files are displayed
        //     from either the Microsoft.Win32.OpenFileDialog or Microsoft.Win32.SaveFileDialog.
        //
        // Returns:
        //     A System.String that contains the filter. The default is System.String.Empty,
        //     which means that no filter is applied and all file types are displayed.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The filter string is invalid.
        string Filter { get; set; }
        //
        // Summary:
        //     Gets or sets the index of the filter currently selected in a file dialog.
        //
        // Returns:
        //     The System.Int32 that is the index of the selected filter. The default is 1.
        int FilterIndex { get; set; }
        //
        // Summary:
        //     Gets or sets the initial directory that is displayed by a file dialog.
        //
        // Returns:
        //     A System.String that contains the initial directory. The default is System.String.Empty.
        string InitialDirectory { get; set; }
        //
        // Summary:
        //     This property is not implemented.
        //
        // Returns:
        //     Not implemented.
        bool RestoreDirectory { get; set; }
        //
        // Summary:
        //     Gets a string that only contains the file name for the selected file.
        //
        // Returns:
        //     A System.String that only contains the file name for the selected file. The default
        //     is System.String.Empty, which is also the value when either no file is selected
        //     or a directory is selected.
        string SafeFileName { get; }
        //
        // Summary:
        //     Gets an array that contains one safe file name for each selected file.
        //
        // Returns:
        //     An array of System.String that contains one safe file name for each selected
        //     file. The default is an array with a single item whose value is System.String.Empty.
        string[] SafeFileNames { get; }
        //
        // Summary:
        //     Gets or sets the text that appears in the title bar of a file dialog.
        //
        // Returns:
        //     A System.String that is the text that appears in the title bar of a file dialog.
        //     The default is System.String.Empty.
        string Title { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the dialog accepts only valid Win32 file
        //     names.
        //
        // Returns:
        //     true if warnings will be shown when an invalid file name is provided; otherwise,
        //     false. The default is false.
        bool ValidateNames { get; set; }

        //
        // Summary:
        //     Occurs when the user selects a file name by either clicking the Open button of
        //     the Microsoft.Win32.OpenFileDialog or the Save button of the Microsoft.Win32.SaveFileDialog.
        event CancelEventHandler FileOk;

        //
        // Summary:
        //     Sets all properties of a file dialog back to their initial values.
        [SecurityCritical]
        void Reset();
    }
}
