using System.Security.AccessControl;
using Microsoft.Win32;
using SystemInterface.Microsoft.Win32;
using SystemInterface.Microsoft.Win32.SafeHandles;
using SystemWrapper.Microsoft.Win32.SafeHandles;
using SystemWrapper.Security.AccessControl;
using SystemInterface.Security.AccessControl;

namespace SystemWrapper.Microsoft.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryKeyWrap : IRegistryKey
    {
        #region Implementation of IDisposable
        /// <summary>
        /// Implementation of the Dispose
        /// </summary>
        public void Dispose()
        {
            RegistryKeyInstance.Dispose();
        }

        #endregion

        #region Constructors and Initializers

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Microsoft.Win32.RegistryKeyWrap"/> class. 
        /// </summary>
        /// <param name="registryKey"></param>
        public RegistryKeyWrap(RegistryKey registryKey)
        {
            Initialize(registryKey);
        }

        /// <summary>
        /// Initiatlized the RegistryKey instance
        /// </summary>
        /// <param name="registryKey"></param>
        public void Initialize(RegistryKey registryKey)
        {
            _RegistryKeyInstance = registryKey;
        }

        #endregion Constructors and Initializers

        #region Implementation of IRegistryKey

        /// <summary>
        /// Gets <see cref="T:Microsoft.Win32.RegistryKey"/> object.
        /// </summary>
        public RegistryKey RegistryKeyInstance
        {
            get { return _RegistryKeyInstance; }
        } private RegistryKey _RegistryKeyInstance;

        /// <summary>
        /// 
        /// </summary>
        public ISafeRegistryHandle Handle
        {
            get { return new SafeRegistryHandleWrap(RegistryKeyInstance.Handle); }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public string Name
        {
            get { return RegistryKeyInstance.Name; }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public int SubKeyCount
        {
            get { return RegistryKeyInstance.SubKeyCount; }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public int ValueCount
        {
            get { return RegistryKeyInstance.ValueCount; }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public RegistryView View
        {
            get { return RegistryKeyInstance.View; }
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public void Close()
        {
            RegistryKeyInstance.Close();
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <returns></returns>
        public IRegistryKey CreateSubKey(string subkey)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.CreateSubKey(subkey));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <param name="permissionCheck"></param>
        /// <returns></returns>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.CreateSubKey(subkey, permissionCheck));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <param name="permissionCheck"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions options)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.CreateSubKey(subkey, permissionCheck, options));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <param name="permissionCheck"></param>
        /// <param name="registrySecurity"></param>
        /// <returns></returns>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, IRegistrySecurity registrySecurity)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.CreateSubKey(subkey, permissionCheck, registrySecurity.RegistrySecurityInstance));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <param name="permissionCheck"></param>
        /// <param name="registryOptions"></param>
        /// <param name="registrySecurity"></param>
        /// <returns></returns>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions registryOptions, IRegistrySecurity registrySecurity)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.CreateSubKey(subkey, permissionCheck, registryOptions, registrySecurity.RegistrySecurityInstance));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        public void DeleteSubKey(string subkey)
        {
            RegistryKeyInstance.DeleteSubKey(subkey);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <param name="throwOnMissingSubKey"></param>
        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
        {
            RegistryKeyInstance.DeleteSubKey(subkey, throwOnMissingSubKey);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        public void DeleteSubKeyTree(string subkey)
        {
            RegistryKeyInstance.DeleteSubKeyTree(subkey);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="subkey"></param>
        /// <param name="throwOnMissingSubKey"></param>
        public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey)
        {
            RegistryKeyInstance.DeleteSubKeyTree(subkey, throwOnMissingSubKey);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        public void DeleteValue(string name)
        {
            RegistryKeyInstance.DeleteValue(name);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="throwOnMissingValue"></param>
        public void DeleteValue(string name, bool throwOnMissingValue)
        {
            RegistryKeyInstance.DeleteValue(name, throwOnMissingValue);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        public void Flush()
        {
            RegistryKeyInstance.Flush();
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        public IRegistryKey FromHandle(ISafeRegistryHandle handle)
        {
            return new RegistryKeyWrap(RegistryKey.FromHandle(handle.SafeRegistryHandleInstance));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="view"></param>
        /// <returns></returns>
        public IRegistryKey FromHandle(ISafeRegistryHandle handle, RegistryView view)
        {
            return new RegistryKeyWrap(RegistryKey.FromHandle(handle.SafeRegistryHandleInstance, view));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <returns></returns>
        public IRegistrySecurity GetAccessControl()
        {
            return new RegistrySecurityWrap(RegistryKeyInstance.GetAccessControl());
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="includeSections"></param>
        /// <returns></returns>
        public IRegistrySecurity GetAccessControl(AccessControlSections includeSections)
        {
            return new RegistrySecurityWrap(RegistryKeyInstance.GetAccessControl(includeSections));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <returns></returns>
        public string[] GetSubKeyNames()
        {
            return RegistryKeyInstance.GetSubKeyNames();
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetValue(string name)
        {
            return RegistryKeyInstance.GetValue(name);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public object GetValue(string name, object defaultValue)
        {
            return RegistryKeyInstance.GetValue(name, defaultValue);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultValue"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
            return RegistryKeyInstance.GetValue(name, defaultValue, options);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public RegistryValueKind GetValueKind(string name)
        {
            return RegistryKeyInstance.GetValueKind(name);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <returns></returns>
        public string[] GetValueNames()
        {
            return RegistryKeyInstance.GetValueNames();
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="view"></param>
        /// <returns></returns>
        public IRegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
        {
            return new RegistryKeyWrap(RegistryKey.OpenBaseKey(hKey, view));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="machineName"></param>
        /// <returns></returns>
        public IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName)
        {
            return new RegistryKeyWrap(RegistryKey.OpenRemoteBaseKey(hKey, machineName));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="machineName"></param>
        /// <param name="view"></param>
        /// <returns></returns>
        public IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName, RegistryView view)
        {
            return new RegistryKeyWrap(RegistryKey.OpenRemoteBaseKey(hKey, machineName, view));

        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IRegistryKey OpenSubKey(string name)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.OpenSubKey(name));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="permissionCheck"></param>
        /// <returns></returns>
        public IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.OpenSubKey(name, permissionCheck));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="writable"></param>
        /// <returns></returns>
        public IRegistryKey OpenSubKey(string name, bool writable)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.OpenSubKey(name, writable));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="permissionCheck"></param>
        /// <param name="rights"></param>
        /// <returns></returns>
        public IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights)
        {
            return new RegistryKeyWrap(RegistryKeyInstance.OpenSubKey(name, permissionCheck, rights));
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="registrySecurity"></param>
        public void SetAccessControl(IRegistrySecurity registrySecurity)
        {
            RegistryKeyInstance.SetAccessControl(registrySecurity.RegistrySecurityInstance);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetValue(string name, object value)
        {
            RegistryKeyInstance.SetValue(name, value);
        }

        /// <summary>
        /// TODO: Add Comment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="valueKind"></param>
        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
            RegistryKeyInstance.SetValue(name, value, valueKind);
        }

        #endregion
    }
}