using SystemWrapper.Diagnostics;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Tests.IO
{
	[TestFixture]
	[Author("Brad Irby", "Brad@BradIrby.com")]
	public class ProcessWrapTests
	{

			[SetUp]
			public void Setup()
			{
			}

			[Test]
			public void Constructor_Sets_ProcessInstance()
			{
				var instance = new ProcessWrap();
				Assert.IsNotNull(instance.ProcessInstance);
			}

			[Test]
			public void Initializer_Sets_ProcessInstance()
			{
				var instance = new ProcessWrap();
				var origInfo = instance.ProcessInstance;
				instance.Initialize();
				Assert.AreNotSame(origInfo, instance.ProcessInstance);
				Assert.IsNotNull(instance.ProcessInstance);
			}

	}
}