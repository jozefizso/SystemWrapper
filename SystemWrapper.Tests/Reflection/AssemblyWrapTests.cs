using System;
using System.IO;
using SystemWrapper.IO;
using SystemWrapper.Reflection;
using NUnit.Framework;
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
            StringAssert.EndsWith("mscorlib.dll", fileStreams[0].Name);
        }

        [Test]
        public void Load_AssemblyString_ReturnsWrapperAssemblyObject()
        {
            // Arrange
            var expectedAssemblyFullName = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
            var assembly = new AssemblyWrap();

            // Act
            var actualAssembly = assembly.Load(expectedAssemblyFullName);

            // Assert
            Assert.IsNotNull(actualAssembly);
            Assert.AreEqual(expectedAssemblyFullName, actualAssembly.FullName);
        }

        [Test]
        public void Load_NonExistingAssemblyString_ThrowsFileNotFoundException()
        {
            // Arrange
            var expectedAssemblyFullName = "FakeAssemblyName, Version=0.0.1.0, Culture=neutral";
            var assembly = new AssemblyWrap();

            // Act & Assert
            var actualException = Assert.Throws<FileNotFoundException>(() => assembly.Load(expectedAssemblyFullName));
            StringAssert.StartsWith("Could not load file or assembly 'FakeAssemblyName, Version=0.0.1.0, Culture=neutral' or one of its dependencies.", actualException.Message);
        }
    }
}