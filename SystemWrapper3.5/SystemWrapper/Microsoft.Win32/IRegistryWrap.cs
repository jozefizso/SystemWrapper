namespace SystemWrapper.Microsoft.Win32
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.Registry"/> class.
    /// </summary>
    public interface IRegistryWrap
    {
        // Properties

        /// <summary>
        /// Contains the configuration data for the local machine. This field reads the Windows registry base key HKEY_LOCAL_MACHINE.
        /// </summary>
        IRegistryKeyWrap LocalMachine { get; }

        // Properties
        //    public static readonly RegistryKey ClassesRoot;
        //    public static readonly RegistryKey CurrentConfig;
        //    public static readonly RegistryKey CurrentUser;
        //    public static readonly RegistryKey DynData;
        //    public static readonly RegistryKey PerformanceData;
        //    public static readonly RegistryKey Users;
        //
        //    // Methods
        //    static Registry();
        //    private static RegistryKey GetBaseKeyFromKeyName(string keyName, out string subKeyName);
        //    public static object GetValue(string keyName, string valueName, object defaultValue);
        //    public static void SetValue(string keyName, string valueName, object value);
        //    public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);

    }
}