using System.Collections.Specialized;

namespace SystemWrapper.Configuration
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Configuration.ConfigurationManager"/> class.
    /// </summary>
    public interface IConfigurationManagerWrap
    {
        // Properties
        /// <summary>
        /// Gets the AppSettingsSection  data for the current application's default configuration.
        /// </summary>
        NameValueCollection AppSettings { get; }

        /*
                // Methods
            public static object GetSection(string sectionName);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenExeConfiguration(string exePath);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenMachineConfiguration();
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap);
            public static void RefreshSection(string sectionName);

            // Properties
            public static ConnectionStringSettingsCollection ConnectionStrings { get; }
        */
    }
}