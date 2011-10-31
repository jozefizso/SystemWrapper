using SystemWrapper.IO;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Samples.IO
{
    public class FileInfoSample
    {
        public void CreateAndDeleteFile(IFileInfoWrap fi)
        {
            IFileStreamWrap fs = fi.Create();
            fs.Close();
            fi.Delete();
        }
    }

    public class FileInfoSampleTest
    {
        [Test]
        public void Check_that_FileInfo_methods_Create_and_Delete_are_called()
        {
            // Add mock repository.
            IFileInfoWrap fileInfoRepository = MockRepository.GenerateMock<IFileInfoWrap>();
            IFileStreamWrap fileStreamRepository = MockRepository.GenerateMock<IFileStreamWrap>();

            // Create expectations
            fileInfoRepository.Expect(x => x.Create()).Return(fileStreamRepository);
            fileStreamRepository.Expect(x => x.Close());
            fileInfoRepository.Expect(x => x.Delete());

            // Test
            new FileInfoSample().CreateAndDeleteFile(fileInfoRepository);

            // Verify expectations.
            fileInfoRepository.VerifyAllExpectations();
            fileStreamRepository.VerifyAllExpectations();
        }

    }
}