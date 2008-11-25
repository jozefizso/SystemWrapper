using SystemWrapper.IO;
using MbUnit.Framework;

namespace SystemWrapper.Tests.IO
{
    [TestFixture]
    [Author("Vadim Kreynin", "Vadim@kreynin.com")]
    public class DirectoryInfoWrapTests
    {
        [Test]
        public void Create_two_directories_and_then_delete_them()
        {
            string path = new DirectoryWrap().GetCurrentDirectory();
            IDirectoryInfoWrap directoryInfoWrap = new DirectoryInfoWrap(path);
            directoryInfoWrap.CreateSubdirectory("Dir1");
            directoryInfoWrap.CreateSubdirectory("Dir2");
            IDirectoryInfoWrap[] directories = directoryInfoWrap.GetDirectories();
            Assert.AreEqual("Dir1", directories[0].Name);
            Assert.AreEqual("Dir2", directories[1].Name);
            directories[0].Delete();
            directories[1].Delete();
            directories = directoryInfoWrap.GetDirectories();
            Assert.AreEqual(0, directories.Length);
        }

        [Test]
        public void GetFiles_must_have_files_in_Debug_folder()
        {
            IDirectoryInfoWrap directoryWrap = new DirectoryInfoWrap(new DirectoryWrap().GetCurrentDirectory());
            IFileInfoWrap[] fileInfoWraps = directoryWrap.GetFiles();
            Assert.IsTrue(fileInfoWraps.Length > 0);
        }

    }
}