using System;
using SystemWrapper.IO;
using SystemWrapper.Reflection;
using MbUnit.Framework;

namespace SystemWrapper.Tests.Reflection
{
    [TestFixture]
    public class AssemblyWrapTests
    {
        [Test]
        public void GetFiles_Test()
        {
            IAssemblyWrap sampleAssembly = new AssemblyWrap();
            sampleAssembly = sampleAssembly.GetAssembly(new Int32().GetType());
            IFileStreamWrap[] fileStreams = sampleAssembly.GetFiles();
            Assert.AreEqual(1, fileStreams.Length);
            Assert.EndsWith(fileStreams[0].Name, "mscorlib.dll");
        }
    }
}