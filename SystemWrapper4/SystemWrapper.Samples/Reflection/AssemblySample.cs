using SystemWrapper.Reflection;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Samples
{
    public class AssemblySample
    {
        private IAssemblyWrap _assembly;

        public AssemblySample(IAssemblyWrap assemblyWrap)
        {
            _assembly = assemblyWrap;
        }

        public string GetAssemblyVersion()
        {
            _assembly = _assembly.GetExecutingAssembly();
            return _assembly.GetName().Version.ToString();
        }
    }

    public class AssemblySampleTests
    {
        [Test]
        public void GetAssemblyVersion_test()
        {
            IAssemblyWrap assemblyStub = MockRepository.GenerateStub<IAssemblyWrap>();
            IAssemblyNameWrap assemblyNameStub = MockRepository.GenerateStub<IAssemblyNameWrap>();

            assemblyStub.Stub(x => x.GetExecutingAssembly()).Return(assemblyStub);
            assemblyStub.Stub(x => x.GetName()).Return(assemblyNameStub);
            assemblyNameStub.Version = new VersionWrap(1, 2, 3, 4);

            Assert.AreEqual("1.2.3.4", new AssemblySample(assemblyStub).GetAssemblyVersion());
        }
    }
}
