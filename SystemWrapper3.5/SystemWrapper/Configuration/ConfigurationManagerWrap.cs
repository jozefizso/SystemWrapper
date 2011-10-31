using System.Collections.Specialized;
using System.Configuration;

namespace SystemWrapper.Configuration
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Configuration.ConfigurationManager"/> class.
    /// </summary>
    public class ConfigurationManagerWrap : IConfigurationManagerWrap
    {
        /// <inheritdoc />
        public NameValueCollection AppSettings
        {
            get { return ConfigurationManager.AppSettings; }
        }

		/// <inheritdoc />
        public ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return ConfigurationManager.ConnectionStrings; }
        }

		/// <inheritdoc />
		public object GetSection(string pSectionName)
		{
			return ConfigurationManager.GetSection(pSectionName);
		}

		/// <inheritdoc />
		public System.Configuration.Configuration OpenExeConfiguration(string pExePath)
		{
			return ConfigurationManager.OpenExeConfiguration(pExePath);
		}

		/// <inheritdoc />
		public System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel pConfigurationUserLevel)
		{
			return ConfigurationManager.OpenExeConfiguration(pConfigurationUserLevel);
		}

		/// <inheritdoc />
		public System.Configuration.Configuration OpenMachineConfiguration()
		{
			return ConfigurationManager.OpenMachineConfiguration();
		}

		/// <inheritdoc />
		public System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap pExeConfigurationFileMap, ConfigurationUserLevel pConfigurationUserLevel)
		{
			return ConfigurationManager.OpenMappedExeConfiguration(pExeConfigurationFileMap, pConfigurationUserLevel);
		}

		/// <inheritdoc />
		public System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap pConfigurationFileMap)
		{
			return ConfigurationManager.OpenMappedMachineConfiguration(pConfigurationFileMap);
		}

		/// <inheritdoc />
		public void RefreshSection(string pSectionName)
		{
			ConfigurationManager.RefreshSection(pSectionName);
		}
    }
}