using System;
using SystemWrapper.IO;
using SystemWrapper.Reflection;
using MbUnit.Framework;
using SystemInterface.IO;
using SystemInterface.Reflection;

namespace SystemWrapper.Tests.Reflection
{
    [TestFixture]
    public class AssemblyWrapTests
    {
        [Test]
        public void GetFiles_Test()
        {
            IAssembly sampleAssembly = new AssemblyWrap();
            sampleAssembly = sampleAssembly.GetAssembly(new Int32().GetType());
            IFileStream[] fileStreams = sampleAssembly.GetFiles();
            Assert.AreEqual(1, fileStreams.Length);
            Assert.EndsWith(fileStreams[0].Name, "mscorlib.dll");
        }
    }
}