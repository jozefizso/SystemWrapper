using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using SystemWrapper.IO;

namespace SystemWrapper.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="System.Reflection.Assembly"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class AssemblyWrap : IAssemblyWrap
    {
        private Assembly _assembly;

		#region Constructors and Initializers

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
			Initialize(assembly);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Reflection.AssemblyWrap"/> class. 
		/// </summary>
		/// <param name="assembly">Assembly object.</param>
		public void Initialize(Assembly assembly)
		{
			_assembly = assembly;
		}

		#endregion Constructors and Initializers
		
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

        public object CreateInstance(string typeName)
        {
            return AssemblyInstance.CreateInstance(typeName);
        }

        public object CreateInstance(string typeName, bool ignoreCase)
        {
            return AssemblyInstance.CreateInstance(typeName, ignoreCase);
        }

        public object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            return AssemblyInstance.CreateInstance(typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
        }

        public string CreateQualifiedName(string assemblyName, string typeName)
        {
            return Assembly.CreateQualifiedName(assemblyName, typeName);
        }

        public override bool Equals(object obj)
        {
            return AssemblyInstance.Equals(obj);
        }

        public IAssemblyWrap GetAssembly(Type type)
        {
            return new AssemblyWrap(Assembly.GetAssembly(type));
        }

        public IAssemblyWrap GetCallingAssembly()
        {
            return new AssemblyWrap(Assembly.GetCallingAssembly());
        }

        public virtual object[] GetCustomAttributes(bool inherit)
        {
            return AssemblyInstance.GetCustomAttributes(inherit);
        }

        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return AssemblyInstance.GetCustomAttributes(attributeType, inherit);
        }

        public IAssemblyWrap GetEntryAssembly()
        {
            return new AssemblyWrap(Assembly.GetEntryAssembly());
        }

        public IAssemblyWrap GetExecutingAssembly()
        {
            return new AssemblyWrap(Assembly.GetExecutingAssembly());
        }

        public virtual Type[] GetExportedTypes()
        {
            return AssemblyInstance.GetExportedTypes();
        }

        public IFileStreamWrap GetFile(string name)
        {
            return new FileStreamWrap(AssemblyInstance.GetFile(name));
        }

        public virtual IFileStreamWrap[] GetFiles()
        {
            return FileStreamWrap.ConvertFileStreamArrayIntoIFileStreamWrapArray(AssemblyInstance.GetFiles());
        }

        public IFileStreamWrap[] GetFiles(bool getResourceModules)
        {
            return FileStreamWrap.ConvertFileStreamArrayIntoIFileStreamWrapArray(AssemblyInstance.GetFiles(getResourceModules));
        }

        public override int GetHashCode()
        {
            return AssemblyInstance.GetHashCode();
        }

        public IAssemblyNameWrap GetName()
        {
            return new AssemblyNameWrap(AssemblyInstance.GetName());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            AssemblyInstance.GetObjectData(info, context);
        }

        public IAssemblyNameWrap[] GetReferencedAssemblies()
        {
            AssemblyName[] assemblyNames = AssemblyInstance.GetReferencedAssemblies();
            return AssemblyNameWrap.ConvertFileInfoArrayIntoIFileInfoWrapArray(assemblyNames);
        }

        public bool IsDefined(Type attributeType, bool inherit)
        {
            return AssemblyInstance.IsDefined(attributeType, inherit);
        }

        public IAssemblyWrap LoadFrom(string assemblyFile)
        {
            return new AssemblyWrap(Assembly.LoadFrom(assemblyFile));
        }
    }
}