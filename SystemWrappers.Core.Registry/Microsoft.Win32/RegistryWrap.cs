using Microsoft.Win32;

namespace SystemWrappers.Core.Registry.Microsoft.Win32
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.Registry"/> class.
    /// </summary>
    public class RegistryWrap : IRegistry
    {
        #region Implementation of IRegistry

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public IRegistryKey ClassesRoot
        {
            get
            {
                RegistryKey key = global::Microsoft.Win32.Registry.ClassesRoot;
                if (null == key)
                    return null;
                else
                    return new RegistryKeyWrap(key);
            }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public IRegistryKey CurrentConfig
        {
            get
            {
                RegistryKey key = global::Microsoft.Win32.Registry.CurrentConfig;
                if (null == key)
                    return null;
                else
                    return new RegistryKeyWrap(key);
            }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public IRegistryKey CurrentUser
        {
            get
            {
                RegistryKey key = global::Microsoft.Win32.Registry.CurrentUser;
                if (null == key)
                    return null;
                else
                    return new RegistryKeyWrap(key);
            }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public IRegistryKey LocalMachine
        {
            get
            {
                RegistryKey key = global::Microsoft.Win32.Registry.LocalMachine;
                if (null == key)
                    return null;
                else
                    return new RegistryKeyWrap(key);
            }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public IRegistryKey PerformanceData
        {
            get
            {
                RegistryKey key = global::Microsoft.Win32.Registry.PerformanceData;
                if (null == key)
                    return null;
                else
                    return new RegistryKeyWrap(key);
            }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public IRegistryKey Users
        {
            get
            {
                RegistryKey key = global::Microsoft.Win32.Registry.Users;
                if (null == key)
                    return null;
                else
                    return new RegistryKeyWrap(key);
            }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public object GetValue(string keyName, string valueName, object defaultValue)
        {
            return global::Microsoft.Win32.Registry.GetValue(keyName, valueName, defaultValue);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="value"></param>
        public void SetValue(string keyName, string valueName, object value)
        {
            global::Microsoft.Win32.Registry.SetValue(keyName, valueName, value);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="value"></param>
        /// <param name="valueKind"></param>
        public void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind)
        {
            global::Microsoft.Win32.Registry.SetValue(keyName, valueName, value, valueKind);
        }

        #endregion Implementation of IRegistry
    }
}
