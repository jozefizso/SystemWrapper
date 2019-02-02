using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemInterface;

namespace SystemWrapper.Tests
{
    [TestClass]
    public class DateTimeWrapTests
    {
        const long dateTicks = 636846612300000000L;

        [TestMethod]
        public void Equatable_SameDateTime()
        {
            IDateTime date1 = new DateTimeWrap(dateTicks);
            IDateTime date2 = new DateTimeWrap(dateTicks);
            object dateObject = new DateTimeWrap(dateTicks);

            Assert.AreEqual(date1, date1);
            Assert.AreEqual(date1, date2);
            Assert.AreEqual(date1, dateObject);
            Assert.AreEqual(date1.GetHashCode(), date2.GetHashCode());
        }

        [TestMethod]
        public void Equatable_DifferentDateTime()
        {
            var date1 = new DateTimeWrap(dateTicks);
            var date2 = new DateTimeWrap(dateTicks + 1L);
            object dateObject = new DateTimeWrap(dateTicks + 1L);

            Assert.AreNotEqual(date1, null);
            Assert.AreNotEqual(date1, date2);
            Assert.AreNotEqual(date1, dateObject);
        }
    }
}
