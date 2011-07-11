using System;
using System.Runtime.InteropServices;
using SystemWrapper.Reflection;

namespace SystemWrapper
{
    /// <summary>
    /// Wrapper for <see cref="System.AppDomain"/> class.
    /// </summary>
    [ComVisible(true)] 
    [Serializable]
    public class AppDomainWrap : IAppDomainWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.AppDomainWrap"/> class. 
		/// </summary>
		/// <param name="appDomain">AppDomain object.</param>
		public AppDomainWrap(AppDomain appDomain)
		{
			Initialize(appDomain);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.AppDomainWrap"/> class. 
		/// </summary>
		/// <param name="appDomain">AppDomain object.</param>
		public void Initialize(AppDomain appDomain)
		{
			AppDomainInstance = appDomain;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.AppDomainWrap"/> class and creates a new application domain with the specified name.
		/// </summary>
		/// <param name="friendlyName">The friendly name of the domain.</param>
		public AppDomainWrap(string friendlyName)
		{
			Initialize(friendlyName);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.AppDomainWrap"/> class and creates a new application domain with the specified name.
		/// </summary>
		/// <param name="friendlyName">The friendly name of the domain.</param>
		public void Initialize(string friendlyName)
		{
			AppDomainInstance = AppDomain.CreateDomain(friendlyName);
		}

    	#endregion Constructors and Initializers
		
		public AppDomain AppDomainInstance { get; private set; }

        public IAppDomainWrap CurrentDomain
        {
            get { return new AppDomainWrap(AppDomain.CurrentDomain); }
        }

        public object GetData(string name)
        {
            return AppDomainInstance.GetData(name);
        }

        public IAssemblyWrap Load(IAssemblyNameWrap assemblyRef)
        {
            return new AssemblyWrap(AppDomainInstance.Load(assemblyRef.AssemblyNameInstance));
        }

        public void SetData(string name, object data)
        {
            AppDomainInstance.SetData(name, data);
        }

        public void Unload(IAppDomainWrap domain)
        {
            AppDomain.Unload(domain.AppDomainInstance);
        }

        event ResolveEventHandler IAppDomainWrap.AssemblyResolve
        {
            add { AppDomainInstance.AssemblyResolve += value; }
            remove { AppDomainInstance.AssemblyResolve -= value; }
        }
    }
}