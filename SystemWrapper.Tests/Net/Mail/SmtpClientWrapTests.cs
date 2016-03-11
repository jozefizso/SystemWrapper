using SystemWrapper.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SystemWrapper.Tests.Net.Mail
{
    [TestClass]
    public class SmtpClientWrapTests
    {
        [TestMethod]
        public void InstanceIsNotNull()
        {
            var smtpClientWrap = new SmtpClientWrap();
            Assert.IsNotNull(smtpClientWrap.Instance);
        }
    }
}