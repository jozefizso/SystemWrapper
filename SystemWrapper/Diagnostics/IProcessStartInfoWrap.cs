using System.Diagnostics;

namespace SystemWrapper.Diagnostics
{
    /// <summary>
    /// Description of IProcessStartInfoWrap
    /// </summary>
    public interface IProcessStartInfoWrap
    {
        // Properties

        /// <summary>
        /// Gets or sets the set of command-line arguments to use when starting the application.
        /// </summary>
        string Arguments { get; set; }
        /// <summary>
        /// Gets or sets the application or document to start.
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// Gets <see cref="T:System.Diagnostics.ProcessStartInfo"/> object.
        /// </summary>
        ProcessStartInfo ProcessStartInfoInstance { get; }
        /// <summary>
        /// Gets or sets a value indicating whether to use the operating system shell to start the process.
        /// </summary>
        bool UseShellExecute { get; set; }

        /*
            // Properties
            public bool CreateNoWindow { get; set; }
            public string Domain { get; set; }
            public StringDictionary EnvironmentVariables { get; }
            public bool ErrorDialog { get; set; }
            public IntPtr ErrorDialogParentHandle { get; set; }
            public bool LoadUserProfile { get; set; }
            public SecureString Password { get; set; }
            public bool RedirectStandardError { get; set; }
            public bool RedirectStandardInput { get; set; }
            public bool RedirectStandardOutput { get; set; }
            public Encoding StandardErrorEncoding { get; set; }
            public Encoding StandardOutputEncoding { get; set; }
            public string UserName { get; set; }
            public string Verb { get; set; }
            public string[] Verbs { get; }
            public ProcessWindowStyle WindowStyle { get; set; }
            public string WorkingDirectory { get; set; }
        */

    }
}