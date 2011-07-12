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
			IDirectoryInfoWrap[] directoriesBefore = directoryInfoWrap.GetDirectories();

            directoryInfoWrap.CreateSubdirectory("Dir1");
            directoryInfoWrap.CreateSubdirectory("Dir2");
            IDirectoryInfoWrap[] directoriesAfterCreate = directoryInfoWrap.GetDirectories();

			Assert.AreEqual("Dir1", directoriesAfterCreate[0].Name);
			Assert.AreEqual("Dir2", directoriesAfterCreate[1].Name);
			directoriesAfterCreate[0].Delete();
			directoriesAfterCreate[1].Delete();

			var directoriesAfterDelete = directoryInfoWrap.GetDirectories();
			Assert.AreEqual(directoriesBefore.Length, directoriesAfterDelete.Length);
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