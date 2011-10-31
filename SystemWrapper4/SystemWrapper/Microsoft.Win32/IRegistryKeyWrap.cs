using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.RegistryKey"/> class.
    /// </summary>
    public interface IRegistryKeyWrap
    {

        /// <summary>
        /// Initialize IRegistryKeyWrap.
        /// </summary>
        /// <param name="registryKey">RegistryKey object.</param>
        void Initialize(RegistryKey registryKey);

        // Methods

        /// <summary>
        /// Closes the key and flushes it to disk if its contents have been modified.
        /// </summary>
        void Close();
        /// <summary>
        /// Retrieves the value associated with the specified name. Returns null if the name/value pair does not exist in the registry.
        /// </summary>
        /// <param name="name">The name of the value to retrieve. This string is not case-sensitive.</param>
        /// <returns>The value associated with name, or null if name is not found.</returns>
        object GetValue(string name);
        /// <summary>
        /// Retrieves a subkey as read-only.
        /// </summary>
        /// <param name="name">The name or path of the subkey to open as read-only. </param>
        /// <returns>The subkey requested, or null if the operation failed.</returns>
        IRegistryKeyWrap OpenSubKey(string name);
        /// <summary>
        /// Retrieves a specified subkey, and specifies whether write access is to be applied to the key.
        /// </summary>
        /// <param name="name">Name or path of the subkey to open. </param>
        /// <param name="writable">Set to true if you need write access to the key. </param>
        /// <returns>The subkey requested, or null if the operation failed.</returns>
        IRegistryKeyWrap OpenSubKey(string name, bool writable);
        /// <summary>
        /// Sets the specified name/value pair.
        /// </summary>
        /// <param name="name">The name of the value to store.</param>
        /// <param name="value">The data to be stored.</param>
        void SetValue(string name, object value);

        // Properties

        /// <summary>
        /// Gets <see cref="T:Microsoft.Win32.RegistryKey"/> object.
        /// </summary>
        RegistryKey RegistryKeyInstance { get; }

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
        //        object GetValue(string name, object defaultValue);
        //        [ComVisible(false)]
        //        object GetValue(string name, object defaultValue, RegistryValueOptions options);
        //        [ComVisible(false)]
        //        RegistryValueKind GetValueKind(string name);
        //        string[] GetValueNames();
        //        RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName);
        //        [ComVisible(false)]
        //        RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck);
        //        [ComVisible(false)]
        //        RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights);
        //        void SetAccessControl(RegistrySecurity registrySecurity);
        //        [ComVisible(false)]
        //        void SetValue(string name, object value, RegistryValueKind valueKind);
        //
        //        // Properties
        //        string Name { get; }
        //        int SubKeyCount { get; }
        //        int ValueCount { get; }
    }
}