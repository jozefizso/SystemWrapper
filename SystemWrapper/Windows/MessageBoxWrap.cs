using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SystemInterface.Windows;

namespace SystemWrapper.Windows
{
    public class MessageBoxWrap : IMessageBox
    {
        public MessageBoxResult Show(string messageBoxText)
        {
            return MessageBox.Show(messageBoxText);
        }

        public MessageBoxResult Show(Window owner, string messageBoxText)
        {
            return MessageBox.Show(owner, messageBoxText);
        }

        public MessageBoxResult Show(string messageBoxText, string caption)
        {
            return MessageBox.Show(messageBoxText, caption);
        }

        public MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            return MessageBox.Show(owner, messageBoxText, caption);
        }

        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            return MessageBox.Show(messageBoxText, caption, button);
        }

        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button);
        }

        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon);
        }

        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon);
        }

        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
        }

        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult);
        }

        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult, options);
        }

        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult, options);
        }
    }
}
