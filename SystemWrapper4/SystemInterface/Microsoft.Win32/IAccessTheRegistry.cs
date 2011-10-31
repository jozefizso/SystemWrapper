namespace SystemInterface.Microsoft.Win32
{
    /// <summary>
    /// This is an interface that demonstrates a good practice
    /// for implementing a class that accesses the registry.
    /// </summary>
    interface IAccessTheRegistry
    {
        /// <summary>
        /// This property allows for passing in a Mock registry key
        /// object that implements IRegistryKey to Mock the registry.
        /// By default though, it will use the same
        /// </summary>
        IRegistryKey BaseKey { get; }

        /// <summary>
        /// This allows for switching the BaseKey to a different IRegistry object.
        /// It is expected this will only be used to mock teh registry for unit testing.
        /// We use this function so that the property can remain read only.
        /// </summary>
        /// <param name="inBaseKey"></param>
        void ChangeBaseKey(IRegistryKey inBaseKey);
    }
}
