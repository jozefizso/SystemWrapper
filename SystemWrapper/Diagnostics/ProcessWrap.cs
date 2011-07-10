using System;
using System.Diagnostics;

namespace SystemWrapper.Diagnostics
{
	///<summary>
	/// Wrapper for <see cref="T:System.Diagnostics.Process"/> class.
	///</summary>
	public class ProcessWrap : IProcessWrap
	{
		private IProcessStartInfoWrap startInfo;

		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Diagnostics.ProcessWrap"/> class.
		/// </summary>
		public ProcessWrap()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.Diagnostics.ProcessWrap"/> class.
		/// </summary>
		public void Initialize()
		{
			ProcessInstance = new Process();
		}

		#endregion
		
		public int ExitCode
		{
			get { return ProcessInstance.ExitCode; }
		}

		public void Close()
		{
			ProcessInstance.Close();
		}

		public Process ProcessInstance { get; private set; }

		public bool Start()
		{
			return ProcessInstance.Start();
		}

		public IProcessStartInfoWrap StartInfo
		{
			get { return startInfo ?? (startInfo = new ProcessStartInfoWrap(ProcessInstance.StartInfo)); }
			set { startInfo = value; }
		}

		public void WaitForExit()
		{
			ProcessInstance.WaitForExit();
		}

		public bool WaitForExit(int milliseconds)
		{
			return ProcessInstance.WaitForExit(milliseconds);
		}

		public bool WaitForInputIdle()
		{
			return ProcessInstance.WaitForInputIdle();
		}
	}
}