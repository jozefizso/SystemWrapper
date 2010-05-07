using System.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    ///<summary>
    /// Wrapper for <see cref="T:System.Diagnostics.ProcessStartInfo"/> class.
    ///</summary>
    public class ProcessStartInfoWrap : IProcessStartInfoWrap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Diagnostics.ProcessStartInfoWrap"/> class without specifying a file name with which to start the process. 
        /// </summary>
        public ProcessStartInfoWrap()
        {
            ProcessStartInfoInstance = new ProcessStartInfo();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Diagnostics.ProcessStartInfoWrap"/> class and specifies a file name such as an application or document with which to start the process.
        /// </summary>
        public ProcessStartInfoWrap(string fileName)
        {
            ProcessStartInfoInstance = new ProcessStartInfo(fileName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Diagnostics.ProcessStartInfoWrap"/> class, specifies an application file name with which to start the process, and specifies a set of command-line arguments to pass to the application.
        /// </summary>
        public ProcessStartInfoWrap(string fileName, string arguments)
        {
            ProcessStartInfoInstance = new ProcessStartInfo(fileName, arguments);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemWrapper.Diagnostics.ProcessStartInfoWrap"/> class with providing ProcessStartInfo instance. 
        /// </summary>
        /// <param name="processStartInfo">ProcessStartInfo instance</param>
        public ProcessStartInfoWrap(ProcessStartInfo processStartInfo)
        {
            ProcessStartInfoInstance = processStartInfo;
        }

        public string Arguments
        {
            get { return ProcessStartInfoInstance.Arguments; }
            set { ProcessStartInfoInstance.Arguments = value; }
        }

        public string FileName
        {
            get { return ProcessStartInfoInstance.FileName; }
            set { ProcessStartInfoInstance.FileName = value; }
        }

        public ProcessStartInfo ProcessStartInfoInstance { get; private set; }

        public bool UseShellExecute
        {
            get { return ProcessStartInfoInstance.UseShellExecute; }
            set { ProcessStartInfoInstance.UseShellExecute = value; }
        }
    }
}