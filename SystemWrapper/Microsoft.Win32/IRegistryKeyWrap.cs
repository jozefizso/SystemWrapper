using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public interface IRegistryKeyWrap
    {

    	void Initialize(RegistryKey registryKey);

        // Methods

        /// <summary>
        /// Closes the key and flushes it to disk if its contents have been modified.
        /// </summary>
        void Close();
//        RegistryKey CreateSubKey(string subkey);
//        [ComVisible(false)]
//        RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck);
//        [ComVisible(false)]
//        RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistrySecurity registrySecurity);
//        void DeleteSubKey(string subkey);
//        void DeleteSubKey(string subkey, bool throwOnMissingSubKey);
//        void DeleteSubKeyTree(string subkey);
//        void DeleteValue(string name);
//        void DeleteValue(string name, bool throwOnMissingValue);
//        void Flush();
//        RegistrySecurity GetAccessControl();
//        RegistrySecurity GetAccessControl(AccessControlSections includeSections);
//        string[] GetSubKeyNames();
        object GetValue(string name);
//        object GetValue(string name, object defaultValue);
//        [ComVisible(false)]
//        object GetValue(string name, object defaultValue, RegistryValueOptions options);
//        [ComVisible(false)]
//        RegistryValueKind GetValueKind(string name);
//        string[] GetValueNames();
//        RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName);
        IRegistryKeyWrap OpenSubKey(string name);
//        [ComVisible(false)]
//        RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck);
        IRegistryKeyWrap OpenSubKey(string name, bool writable);
//        [ComVisible(false)]
//        RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights);
//        void SetAccessControl(RegistrySecurity registrySecurity);
        void SetValue(string name, object value);
//        [ComVisible(false)]
//        void SetValue(string name, object value, RegistryValueKind valueKind);
//
//        // Properties
//        string Name { get; }
        RegistryKey RegistryKeyInstance { get; }
//        int SubKeyCount { get; }
//        int ValueCount { get; }
    }
}