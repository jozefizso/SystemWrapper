using System.Diagnostics;

namespace SystemInterface.Diagnostics
{
    /// <summary>
    /// Interface for wrapping static methods of the <see cref="Process"/> class.
    /// </summary>
    public interface IProcessFactory
    {
        /// <summary>
        ///  Gets a wrapped System.Diagnostics.Process component and associates it with the currently active process.
        /// </summary>
        /// <returns>A wrapped System.Diagnostics.Process component associated with the process resource that is running the calling application.</returns>
        IProcess GetCurrentProcess();

        /// <summary>
        /// Returns a wrapped System.Diagnostics.Process component, given the identifier of a process on the local computer.
        /// </summary>
        /// <param name="processId">The system-unique identifier of a process resource.</param>
        /// <returns>A wrapped System.Diagnostics.Process component that is associated with the local process resource identified by the processId parameter.</returns>
        IProcess GetProcessById(int processId);

        /// <summary>
        /// Returns a wrapped System.Diagnostics.Process component, given the identifier of a process on on the network.
        /// </summary>
        /// <param name="processId">The system-unique identifier of a process resource.</param>
        /// <param name="machineName">The name of a computer on the network.</param>
        /// <returns>A wrapped System.Diagnostics.Process component that is associated with a remote process resource identified by the processId parameter.</returns>
        IProcess GetProcessById(int processId, string machineName);
    }
}
