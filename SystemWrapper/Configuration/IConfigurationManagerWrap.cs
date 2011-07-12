using System.Collections.Specialized;
using System.Configuration;

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

        /// <summary>
        /// Gets the ConnectionStringsSection  data for the current application's default configuration.
        /// </summary>
        ConnectionStringSettingsCollection ConnectionStrings { get; }

		object GetSection(string pSectionName);
		System.Configuration.Configuration OpenExeConfiguration(string pExePath);
		System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel pConfigurationUserLevel);
		System.Configuration.Configuration OpenMachineConfiguration();
		System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap pExeConfigurationFileMap, ConfigurationUserLevel pConfigurationUserLevel);
		System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap pConfigurationFileMap);
		void RefreshSection(string pSectionName);

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
        */
    }
}