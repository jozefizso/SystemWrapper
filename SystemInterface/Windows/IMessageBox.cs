using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemInterface.Windows
{
    public interface IMessageBox : IStaticWrapper
    {
        //
        // Summary:
        //     Displays a message box that has a message and that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText);
        //
        // Summary:
        //     Displays a message box that has a message and title bar caption; and that returns
        //     a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption);
        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText);
        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, and button; and
        //     that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);
        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message and title bar caption; and it returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption);
        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and icon;
        //     and that returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message, title bar caption, and button; and it also returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button);
        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and icon;
        //     and that accepts a default message box result and returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result of
        //     the message box.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);
        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message, title bar caption, button, and icon; and it also returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
        //
        // Summary:
        //     Displays a message box that has a message, title bar caption, button, and icon;
        //     and that accepts a default message box result, complies with the specified options,
        //     and returns a result.
        //
        // Parameters:
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result of
        //     the message box.
        //
        //   options:
        //     A System.Windows.MessageBoxOptions value object that specifies the options.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);
        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message, title bar caption, button, and icon; and accepts a default message
        //     box result and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result of
        //     the message box.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);
        //
        // Summary:
        //     Displays a message box in front of the specified window. The message box displays
        //     a message, title bar caption, button, and icon; and accepts a default message
        //     box result, complies with the specified options, and returns a result.
        //
        // Parameters:
        //   owner:
        //     A System.Windows.Window that represents the owner window of the message box.
        //
        //   messageBoxText:
        //     A System.String that specifies the text to display.
        //
        //   caption:
        //     A System.String that specifies the title bar caption to display.
        //
        //   button:
        //     A System.Windows.MessageBoxButton value that specifies which button or buttons
        //     to display.
        //
        //   icon:
        //     A System.Windows.MessageBoxImage value that specifies the icon to display.
        //
        //   defaultResult:
        //     A System.Windows.MessageBoxResult value that specifies the default result of
        //     the message box.
        //
        //   options:
        //     A System.Windows.MessageBoxOptions value object that specifies the options.
        //
        // Returns:
        //     A System.Windows.MessageBoxResult value that specifies which message box button
        //     is clicked by the user.
        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);

    }
}
