using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    /// <summary>
    /// Wrapper for <see cref="T:Microsoft.Win32.Registry"/> class.
    /// </summary>    
    public class RegistryWrap : IRegistryWrap
    {
        /// <inheritdoc />
        public IRegistryKeyWrap LocalMachine
        {
            get { return new RegistryKeyWrap(Registry.LocalMachine); }
        }
    }
}