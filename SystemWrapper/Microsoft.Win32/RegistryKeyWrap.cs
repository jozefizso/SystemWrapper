using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
	/// <summary>
	/// 
	/// </summary>
	public class RegistryKeyWrap : IRegistryKeyWrap
	{
		private RegistryKey registryKeyInstance;

		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Microsoft.Win32.RegistryKeyWrap"/> class. 
		/// </summary>
		/// <param name="registryKey"></param>
		public RegistryKeyWrap(RegistryKey registryKey)
		{
			Initialize(registryKey);
		}

		/// <inheritdoc />
		public void Initialize(RegistryKey registryKey)
		{
			registryKeyInstance = registryKey;
		}

		#endregion Constructors and Initializers

		/// <inheritdoc />
		public void Close()
		{
			registryKeyInstance.Close();
		}

		/// <inheritdoc />
		public object GetValue(string name)
		{
			return registryKeyInstance.GetValue(name);
		}

		/// <inheritdoc />
		public IRegistryKeyWrap OpenSubKey(string name)
		{
			return new RegistryKeyWrap(registryKeyInstance.OpenSubKey(name));
		}

		/// <inheritdoc />
		public IRegistryKeyWrap OpenSubKey(string name, bool writable)
		{
			return new RegistryKeyWrap(registryKeyInstance.OpenSubKey(name, writable));
		}

		/// <inheritdoc />
		public void SetValue(string name, object value)
		{
			registryKeyInstance.SetValue(name, value);
		}

		/// <inheritdoc />
		public RegistryKey RegistryKeyInstance
		{
			get { return registryKeyInstance; }
		}
	}
}