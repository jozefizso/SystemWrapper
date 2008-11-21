using SystemWrapper.IO;
using MbUnit.Framework;

namespace SystemWrapper.Tests.IO
{
    [TestFixture]
    [Author("Vadim Kreynin", "Vadim@kreynin.com")]
    public class DirectoryWrapTests
    {
        [Test]
        public void CreateDirectory_and_Delete_directory_Test()
        {
            const string path = "TempTest";
            IDirectoryWrap directoryWrap = new DirectoryWrap();
            IDirectoryInfoWrap diWrap = directoryWrap.CreateDirectory(path);
            Assert.IsTrue(diWrap.Exists, "Directory TempTest must be created.");

            directoryWrap.Delete(path);
            Assert.IsFalse(directoryWrap.Exists(path), "Directory TempTest must be removed.");
        }

    }
}