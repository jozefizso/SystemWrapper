using SystemWrapper.Diagnostics;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Tests.IO
{
	[TestFixture]
	[Author("Brad Irby", "Brad@BradIrby.com")]
	public class ProcessWrapTests
	{
			private MockRepository _mockRepository;

			[SetUp]
			public void Setup()
			{
				_mockRepository = new MockRepository();
			}

			[Test]
			public void Constructor_1_Sets_Command_Instance()
			{
				var instance = new ProcessWrap();
				Assert.IsNotNull(instance.ProcessInstance);
			}




			[Test]
			public void Initializer_1_Sets_Command_Instance()
			{
				var instance = new ProcessWrap();
				var origInfo = instance.ProcessInstance;
				instance.Initialize();
				Assert.AreNotSame(origInfo, instance.ProcessInstance);
				Assert.IsNotNull(instance.ProcessInstance);
			}




	}
}