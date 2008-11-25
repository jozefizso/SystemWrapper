using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace SystemWrapper.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="System.Reflection.Assembly"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class AssemblyWrap : IAssemblyWrap
    {
        private readonly Assembly _assembly;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Reflection.AssemblyWrap"/> class. 
        /// </summary>
        public AssemblyWrap()
        {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Reflection.AssemblyWrap"/> class. 
        /// </summary>
        /// <param name="assembly">Assembly object.</param>
        public AssemblyWrap(Assembly assembly)
        {
            _assembly = assembly;
        }

        public Assembly AssemblyInstance
        {
            get
            {
                if (_assembly == null)
                    throw new ArgumentNullException();
                return _assembly;
            }
        }

        public string CodeBase
        {
            get { return AssemblyInstance.CodeBase; }
        }

        public MethodInfo EntryPoint
        {
            get { return AssemblyInstance.EntryPoint; }
        }

        public string EscapedCodeBase
        {
            get { return AssemblyInstance.EscapedCodeBase; }
        }

        public Evidence Evidence
        {
            get { return AssemblyInstance.Evidence; }
        }

        public string FullName
        {
            get { return AssemblyInstance.FullName; }
        }

        public bool GlobalAssemblyCache
        {
            get { return AssemblyInstance.GlobalAssemblyCache; }
        }

        public long HostContext
        {
            get { return AssemblyInstance.HostContext; }
        }

        public string ImageRuntimeVersion
        {
            get { return AssemblyInstance.ImageRuntimeVersion; }
        }

        public string Location
        {
            get { return AssemblyInstance.Location; }
        }

        public Module ManifestModule
        {
            get { return AssemblyInstance.ManifestModule; }
        }

        public bool ReflectionOnly
        {
            get { return AssemblyInstance.ReflectionOnly; }
        }

        public IAssemblyNameWrap GetName()
        {
            return new AssemblyNameWrap(AssemblyInstance.GetName());
        }

        public IAssemblyNameWrap[] GetReferencedAssemblies()
        {
            AssemblyName[] assemblyNames = AssemblyInstance.GetReferencedAssemblies();
            return AssemblyNameWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(assemblyNames);
        }

        public IAssemblyWrap LoadFrom(string assemblyFile)
        {
            return new AssemblyWrap(Assembly.LoadFrom(assemblyFile));
        }
    }
}