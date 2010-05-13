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
    }
}