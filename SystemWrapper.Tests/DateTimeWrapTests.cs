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
        
        [TestMethod]
        public void Comparable_SameDateTime()
        {
            IDateTime date1 = new DateTimeWrap(dateTicks);
            IDateTime date2 = new DateTimeWrap(dateTicks);
            object dateObject = new DateTimeWrap(dateTicks);

            Assert.AreEqual(0, date1.CompareTo(date1));
            Assert.AreEqual(0, date1.CompareTo(date2));
            Assert.AreEqual(date1.CompareTo(dateObject), 0);
        }

        [TestMethod]
        public void Comparable_DifferentDateTime()
        {
            IDateTime date = new DateTimeWrap(dateTicks);
            IDateTime laterDate = new DateTimeWrap(dateTicks + 1);
            object laterDateObject = new DateTimeWrap(dateTicks + 1);

            Assert.AreEqual(1, date.CompareTo(null));
            Assert.AreEqual(-1, date.CompareTo(laterDate));
            Assert.AreEqual(1, laterDate.CompareTo(date));
            Assert.AreEqual(-1, date.CompareTo(laterDateObject));
        }
    }
}
