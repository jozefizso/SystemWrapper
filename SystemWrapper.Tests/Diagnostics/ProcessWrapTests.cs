using System.Diagnostics;
using SystemInterface.Diagnostics;
using SystemWrapper.Diagnostics;
using NUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Tests.Diagnostics
{
    [TestFixture]
    [Author("Brad Irby", "Brad@BradIrby.com")]
    public class ProcessWrapTests
    {
        const string LongRunningCmdFilename = @"TestData\LongRunningProcess.cmd";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_Sets_ProcessInstance()
        {
            var instance = new ProcessWrap();
            Assert.IsNotNull(instance.ProcessInstance);
        }

        [Test]
        public void Initializer_Sets_ProcessInstance()
        {
            var instance = new ProcessWrap();
            var origInfo = instance.ProcessInstance;
            instance.Initialize();
            Assert.AreNotSame(origInfo, instance.ProcessInstance);
            Assert.IsNotNull(instance.ProcessInstance);
        }

        [Test]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void StandardOutput_NotNull_ThrowsExceptionBecauseProcessNotYetStarted()
        {
            var instance = new ProcessWrap();
            var origInfo = instance.ProcessInstance;
            instance.Initialize();
            Assert.AreNotSame(origInfo, instance.ProcessInstance);
            Assert.IsNotNull(instance.ProcessInstance);
            Assert.IsNotNull(instance.StandardOutput);
        }

        [Test]
        public void StartInfo_Set_AssignsStartInfoWrap()
        {
            // Arrange
            var mockProcessStartInfoWrap = MockRepository.GenerateMock<IProcessStartInfo>();
            var processStartInfo = new ProcessStartInfo(); // Can't mock, so going to use the actual thing.
            mockProcessStartInfoWrap.Stub(x => x.ProcessStartInfoInstance).Return(processStartInfo);
            var instance = new ProcessWrap();
            instance.Initialize();

            // Act
            instance.StartInfo = mockProcessStartInfoWrap;

            // Assert
            Assert.AreEqual(mockProcessStartInfoWrap, instance.StartInfo);
            Assert.AreEqual(processStartInfo, instance.StartInfo.ProcessStartInfoInstance);
            Assert.AreEqual(processStartInfo, instance.ProcessInstance.StartInfo);
        }


        [Test]
        [ExpectedException(typeof(System.InvalidOperationException), ExpectedMessage = "No process is associated with this object.")]
        public void Kill_throws_expected_exception_if_process_not_started()
        {
            // Arrange
            var instance = new ProcessWrap();

            // Act
            instance.Kill();
        }



        [Test]
        public void WaitForExit_process_completes()
        {
            // Arrange
            var instance = this.StartLongRunningProcess();
            var initialHasExited = instance.ProcessInstance.HasExited;

            // Act
            instance.WaitForExit(3000);

            // Assert
            Assert.AreEqual(false, initialHasExited);
            Assert.AreEqual(true, instance.ProcessInstance.HasExited);
            Assert.AreEqual(0, instance.ProcessInstance.ExitCode);
        }

        [Test]
        public void WaitForExit_process_times_out()
        {
            // Arrange
            var instance = this.StartLongRunningProcess();
            var initialHasExited = instance.ProcessInstance.HasExited;
            
            // Act
            instance.WaitForExit(100);

            // Assert
            Assert.AreEqual(false, initialHasExited);
            Assert.AreEqual(false, instance.ProcessInstance.HasExited);
        }

        [Test]
        public void Kill_process()
        {
            // Arrange
            var instance = this.StartLongRunningProcess();
            var initialHasExited = instance.ProcessInstance.HasExited;

            // Act
            instance.Kill();
            instance.ProcessInstance.WaitForExit(500);

            // Assert
            Assert.AreEqual(false, initialHasExited);
            Assert.AreEqual(true, instance.ProcessInstance.HasExited);
            Assert.AreEqual(-1, instance.ProcessInstance.ExitCode);
        }

        private ProcessWrap StartLongRunningProcess()
        {
            var assembly = System.Reflection.Assembly.GetAssembly(typeof(ProcessWrap));
            var testFilePath = assembly.CodeBase.Substring(8); //remove the "file://" from the front
            var cmdFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(testFilePath), LongRunningCmdFilename);

            var instance = new ProcessWrap();
            instance.StartInfo = new ProcessStartInfoWrap();
            instance.StartInfo.FileName = cmdFile;
            instance.StartInfo.ProcessStartInfoInstance.CreateNoWindow = true;
            instance.StartInfo.ProcessStartInfoInstance.UseShellExecute = false;

            instance.Start();
            return instance;
        }
    }
}