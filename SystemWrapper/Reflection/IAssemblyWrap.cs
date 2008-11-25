using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;

namespace SystemWrapper.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="System.Reflection.Assembly"/> class.
    /// </summary>
    public interface IAssemblyWrap
    {
        // Properties

        /// <summary>
        /// Gets <see cref="T:System.Reflection.Assembly"/> object.
        /// </summary>
        Assembly AssemblyInstance { get; }
        /// <summary>
        /// Gets the location of the assembly as specified originally, for example, in an <see cref="System.Reflection.AssemblyName"/> object.
        /// </summary>
        string CodeBase { get; }
        /// <summary>
        /// Gets the entry point of this assembly. 
        /// </summary>
        MethodInfo EntryPoint { get; }
        /// <summary>
        /// Gets the URI, including escape characters, that represents the codebase.
        /// </summary>
        string EscapedCodeBase { get; }
        /// <summary>
        /// Gets the evidence for this assembly.
        /// </summary>
        Evidence Evidence { [SecurityPermission(SecurityAction.Demand, ControlEvidence = true)] get; }
        /// <summary>
        /// Gets the display name of the assembly. 
        /// </summary>
        string FullName { get; }
        /// <summary>
        /// Gets a value indicating whether the assembly was loaded from the global assembly cache. 
        /// </summary>
        bool GlobalAssemblyCache { get; }
        /// <summary>
        /// Gets the host context with which the assembly was loaded. 
        /// </summary>
        [ComVisible(false)]
        long HostContext { get; }
        /// <summary>
        /// Gets a string representing the version of the common language runtime (CLR) saved in the file containing the manifest. 
        /// </summary>
        [ComVisible(false)]
        string ImageRuntimeVersion { get; }
        /// <summary>
        /// Gets the path or UNC location of the loaded file that contains the manifest. 
        /// </summary>
        string Location { get; }
        /// <summary>
        /// Gets the module that contains the manifest for the current assembly. 
        /// </summary>
        [ComVisible(false)]
        Module ManifestModule { get; }
        /// <summary>
        /// Gets a <see cref="T:System.Boolean"/> value indicating whether this assembly was loaded into the reflection-only context. 
        /// </summary>
        [ComVisible(false)]
        bool ReflectionOnly { get; }

        // Methods

        /// <summary>
        /// Gets an <see cref="T:SystemWrapper.Reflection.IAssemblyNameWrap"/> for this assembly. 
        /// </summary>
        /// <returns>An <see cref="T:SystemWrapper.Reflection.IAssemblyNameWrap"/> for this assembly. </returns>
        IAssemblyNameWrap GetName();
        /// <summary>
        /// Gets the <see cref="T:SystemWrapper.Reflection.IAssemblyNameWrap"/> objects for all the assemblies referenced by this assembly. 
        /// </summary>
        /// <returns>An array of type <see cref="T:SystemWrapper.Reflection.IAssemblyNameWrap"/> containing all the assemblies referenced by this assembly.</returns>
        IAssemblyNameWrap[] GetReferencedAssemblies();
        /// <summary>
        /// Loads an assembly given its file name or path. 
        /// </summary>
        /// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly.</param>
        /// <returns>The loaded assembly. </returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        IAssemblyWrap LoadFrom(string assemblyFile);

        /*
            public object CreateInstance(string typeName);
            public object CreateInstance(string typeName, bool ignoreCase);
            public object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
            [MethodImpl(MethodImplOptions.InternalCall)]
            public static extern string CreateQualifiedName(string assemblyName, string typeName);
            public override bool Equals(object o);
            public static Assembly GetAssembly(Type type);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly GetCallingAssembly();
            public virtual object[] GetCustomAttributes(bool inherit);
            public virtual object[] GetCustomAttributes(Type attributeType, bool inherit);
            public static Assembly GetEntryAssembly();
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly GetExecutingAssembly();
            public virtual Type[] GetExportedTypes();
            public virtual FileStream GetFile(string name);
            public virtual FileStream[] GetFiles();
            public virtual FileStream[] GetFiles(bool getResourceModules);
            public override int GetHashCode();
            public Module[] GetLoadedModules();
            public Module[] GetLoadedModules(bool getResourceModules);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName);
            public virtual string[] GetManifestResourceNames();
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual Stream GetManifestResourceStream(string name);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual Stream GetManifestResourceStream(Type type, string name);
            public Module GetModule(string name);
            public Module[] GetModules();
            public Module[] GetModules(bool getResourceModules);
            public virtual AssemblyName GetName(bool copiedName);
            [SecurityPermission(SecurityAction.LinkDemand, Flags=SecurityPermissionFlag.SerializationFormatter)]
            public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
            public Assembly GetSatelliteAssembly(CultureInfo culture);
            public Assembly GetSatelliteAssembly(CultureInfo culture, Version version);
            public virtual Type GetType(string name);
            public virtual Type GetType(string name, bool throwOnError);
            public Type GetType(string name, bool throwOnError, bool ignoreCase);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual Type[] GetTypes();
            public virtual bool IsDefined(Type attributeType, bool inherit);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(byte[] rawAssembly);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(AssemblyName assemblyRef);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(string assemblyString);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(string assemblyString, Evidence assemblySecurity);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
            [MethodImpl(MethodImplOptions.NoInlining), SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlEvidence)]
            public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
            public static Assembly LoadFile(string path);
            [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlEvidence)]
            public static Assembly LoadFile(string path, Evidence securityEvidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
            public Module LoadModule(string moduleName, byte[] rawModule);
            public Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
            [MethodImpl(MethodImplOptions.NoInlining), Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
            public static Assembly LoadWithPartialName(string partialName);
            [MethodImpl(MethodImplOptions.NoInlining), Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
            public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly ReflectionOnlyLoad(string assemblyString);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly ReflectionOnlyLoad(byte[] rawAssembly);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly ReflectionOnlyLoadFrom(string assemblyFile);
            Type _Assembly.GetType();
            public override string ToString();
          
         * // Events
            public event ModuleResolveEventHandler ModuleResolve;

       */

    }
}