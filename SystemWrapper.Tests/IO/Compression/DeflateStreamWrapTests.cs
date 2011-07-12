using System.IO;
using System.IO.Compression;
using System.Net.Mime;
using SystemWrapper.IO;
using SystemWrapper.IO.Compression;
using MbUnit.Framework;
using Rhino.Mocks;
using System.Windows.Forms;

namespace SystemWrapper.Tests.IO
{
	[TestFixture]
	[Author("Brad Irby", "Brad@BradIrby.com")]
	public class DeflateStreamWrapTests
	{
		private FileStream _fileStream;

		[FixtureSetUp]
		public void FixtureSetup()
		{
			var assembly = System.Reflection.Assembly.GetAssembly(typeof(DeflateStreamWrap));
			var testFilePath = assembly.CodeBase.Substring(8);  //remove the "file://" from the front
			testFilePath = Path.GetDirectoryName(testFilePath) + "\\TestData\\DeflateStreamWrapTestData.txt";
			
			_fileStream = new FileStream(testFilePath, FileMode.Open);
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Constructor_Sets_DeflateStreamInstance()
		{
			var mockStream = MockRepository.GenerateMock<IStreamWrap>();
			mockStream.Stub(mo => mo.StreamInstance).Return(_fileStream);

			var instance = new DeflateStreamWrap(mockStream, CompressionMode.Compress);
			Assert.IsNotNull(instance.DeflateStreamInstance);
		}

		[Test]
		public void Initialize_Sets_DeflateStreamInstance()
		{
			var mockStream = MockRepository.GenerateMock<IStreamWrap>();
			mockStream.Stub(mo => mo.StreamInstance).Return(_fileStream);
			var instance = new DeflateStreamWrap();
			instance.Initialize(mockStream, CompressionMode.Compress);
			Assert.IsNotNull(instance.DeflateStreamInstance);
		}


	}
}