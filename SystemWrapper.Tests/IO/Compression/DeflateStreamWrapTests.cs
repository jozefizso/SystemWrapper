using System.IO.Compression;
using SystemWrapper.IO;
using SystemWrapper.IO.Compression;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Tests.IO
{
    [TestFixture]
    [Author("Brad Irby", "Brad@BradIrby.com")]
	public class DeflateStreamWrapTests
    {
		private MockRepository _mockRepository;

		[SetUp]
		public void Setup()
		{
			_mockRepository = new MockRepository();
		}

		//[Test]
		//public void Constructor_Sets_DeflateStreamInstance()
		//{
		//    var mockStream = _mockRepository.Stub<IStreamWrap>();
		//    var instance = new DeflateStreamWrap(mockStream, CompressionMode.Compress);
		//    Assert.IsNotNull(instance.DeflateStreamInstance);
		//}

		//[Test]
		//public void Initialize_Sets_DeflateStreamInstance()
		//{
		//    var mockStream = _mockRepository.Stub<IStreamWrap>();
		//    var instance = new DeflateStreamWrap();
		//    instance.Initialize(mockStream, CompressionMode.Compress);
		//    Assert.IsNotNull(instance.DeflateStreamInstance);
		//}


    }
}