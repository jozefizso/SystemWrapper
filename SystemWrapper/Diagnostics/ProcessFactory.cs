using System.Diagnostics;
using SystemInterface.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    /// <summary>
    /// Wrapper implementation of static methods from the <see cref="Process"/> class.
    /// </summary>
    public class ProcessFactory : IProcessFactory
    {
        /// <inheritdoc />
        public IProcess GetCurrentProcess()
        {
            var process = Process.GetCurrentProcess();

            return new ProcessWrap(process);
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId)
        {
            var process = Process.GetProcessById(processId);

            return new ProcessWrap(process);
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId, string machineName)
        {
            var process = Process.GetProcessById(processId, machineName);

            return new ProcessWrap(process);
        }
    }
}
