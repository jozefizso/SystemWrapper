using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterface.Diagnostics;
using SystemWrapper.Diagnostics;

namespace SystemWrapper.Tests.Diagnostics
{
    [TestFixture(Category = @"SystemWrapper.Diagnostics.FileVersionInfoWrap")]
    [Author("Chris Bush", "cjbush77@gmail.com")]
    public class FileVersionInfoWrapTests
    {
        private System.Diagnostics.FileVersionInfo expected;
        private IFileVersionInfo subject;
        private IFileVersionInfoFactory factory;

        const string filename = @"TestData\BinaryReaderWrapTestData.txt";

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            var absPath = System.IO.Path.GetFullPath(filename);
            factory = new FileVersionInfoFactory();
            expected = System.Diagnostics.FileVersionInfo.GetVersionInfo(absPath);
            subject = factory.GetVersionInfo(absPath);
        }

        [Test]
        public void Factory_ShouldReturn_ValidWrapper()
        {
            var test = factory.GetVersionInfo(filename);
            Assert.IsNotNull(test);
            Assert.IsInstanceOf<FileVersionInfoWrap>(test);
        }

        [Test]
        public void Wrap_ShouldHave_AllProperties()
        {
            Assert.IsNotNull(subject.Instance);
            Assert.IsInstanceOf<System.Diagnostics.FileVersionInfo>(subject.Instance);
            Assert.AreEqual(expected.Comments, subject.Comments);
            Assert.AreEqual(expected.CompanyName, subject.CompanyName);
            Assert.AreEqual(expected.FileBuildPart, subject.FileBuildPart);
            Assert.AreEqual(expected.FileDescription, subject.FileDescription);
            Assert.AreEqual(expected.FileMajorPart, subject.FileMajorPart);
            Assert.AreEqual(expected.FileMinorPart, subject.FileMinorPart);
            Assert.AreEqual(expected.FileName, subject.FileName);
            Assert.AreEqual(expected.FilePrivatePart, subject.FilePrivatePart);
            Assert.AreEqual(expected.FileVersion, subject.FileVersion);
            Assert.AreEqual(expected.InternalName, subject.InternalName);
            Assert.AreEqual(expected.IsDebug, subject.IsDebug);
            Assert.AreEqual(expected.IsPatched, subject.IsPatched);
            Assert.AreEqual(expected.IsPreRelease, subject.IsPreRelease);
            Assert.AreEqual(expected.IsPrivateBuild, subject.IsPrivateBuild);
            Assert.AreEqual(expected.IsSpecialBuild, subject.IsSpecialBuild);
            Assert.AreEqual(expected.Language, subject.Language);
            Assert.AreEqual(expected.LegalCopyright, subject.LegalCopyright);
            Assert.AreEqual(expected.LegalTrademarks, subject.LegalTrademarks);
            Assert.AreEqual(expected.OriginalFilename, subject.OriginalFilename);
            Assert.AreEqual(expected.PrivateBuild, subject.PrivateBuild);
            Assert.AreEqual(expected.ProductBuildPart, subject.ProductBuildPart);
            Assert.AreEqual(expected.ProductMajorPart, subject.ProductMajorPart);
            Assert.AreEqual(expected.ProductMinorPart, subject.ProductMinorPart);
            Assert.AreEqual(expected.ProductName, subject.ProductName);
            Assert.AreEqual(expected.ProductPrivatePart, subject.ProductPrivatePart);
            Assert.AreEqual(expected.ProductVersion, subject.ProductVersion);
            Assert.AreEqual(expected.SpecialBuild, subject.SpecialBuild);
            Assert.AreEqual(expected.ToString(), subject.ToString());
        }
    }
}
