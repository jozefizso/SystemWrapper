using System;
using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryKeyWrap : IRegistryKeyWrap
    {
        private RegistryKey _registryKeyInstance;

		#region Constructors and Initializers

		public RegistryKeyWrap(RegistryKey registryKey)
		{
			Initialize(registryKey);
		}

		public void Initialize(RegistryKey registryKey)
		{
			_registryKeyInstance = registryKey;
		}

		#endregion Constructors and Initializers
		
		public void Close()
        {
            throw new NotImplementedException();
        }

        public object GetValue(string name)
        {
            return _registryKeyInstance.GetValue(name);
        }

        public IRegistryKeyWrap OpenSubKey(string name)
        {
            return new RegistryKeyWrap(_registryKeyInstance.OpenSubKey(name));
        }

        public IRegistryKeyWrap OpenSubKey(string name, bool writable)
        {
            return new RegistryKeyWrap(_registryKeyInstance.OpenSubKey(name, writable));
        }

        public void SetValue(string name, object value)
        {
            _registryKeyInstance.SetValue(name, value);
        }

        public RegistryKey RegistryKeyInstance
        {
            get { return _registryKeyInstance; }
        }
    }
}