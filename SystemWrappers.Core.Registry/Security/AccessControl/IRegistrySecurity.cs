using System.Security.AccessControl;

namespace SystemWrapper.Core.Registry.Security.AccessControl
{
    /// <summary>
    /// Interface to match decoration of the object
    /// <see cref="System.Security.AccessControl.RegistrySecurity"/>.
    /// </summary>
    public interface IRegistrySecurity
    {
        /// <summary>
        /// Gets <see cref="T:System.Security.AccessControl.RegistrySecurity"/> object.
        /// </summary>
        RegistrySecurity RegistrySecurityInstance { get; }
    }
}
