using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
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

        [TestMethod]
        public void InstanceHasPassedInHost()
        {
            var host = "mail.domain.tld";
            var smtpClientWrap = new SmtpClientWrap(host);
            Assert.AreEqual(host, smtpClientWrap.Instance.Host);
        }

        [TestMethod]
        public void InstanceIsPassedInObject()
        {
            var concreteClient = new SmtpClient();
            var smtpClientWrap = new SmtpClientWrap(concreteClient);
            Assert.AreEqual(concreteClient, smtpClientWrap.Instance);
        }

        [TestMethod]
        public void CredentialsAreInstanceCredentials()
        {
            var creds = new NetworkCredential("user1", "password1");
            var smtpClientWrap = new SmtpClientWrap { Credentials = creds };
            Assert.AreEqual(creds, smtpClientWrap.Instance.Credentials);
            Assert.AreEqual(creds, smtpClientWrap.Credentials);
        }
        
        [TestMethod]
        public void EventIsCalled()
        {
            bool wasCalled = false;
            var smtpClientWrap = new SmtpClientWrap();
            smtpClientWrap.SendCompleted += (o, args) => { wasCalled = true; };

            smtpClientWrap.SendCompletedHandler(null, null);
            Assert.IsTrue(wasCalled);
        }
    }
}