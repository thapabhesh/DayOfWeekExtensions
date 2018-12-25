using NUnit.Framework;
using System;

namespace DayOfWeekExtensions.Tests
{
    [TestFixture]
    public partial class DayOfWeekTests
    {
        [Test]
        public void AddDays_1DayOnMonday_Expect_Tuesday()
        {
            var result = DayOfWeek.Monday.AddDays(1);

            Assert.AreEqual(DayOfWeek.Tuesday, result);
        }

        [Test]
        public void AddDays_5DaysOnMonday_Expect_Saturday()
        {
            var result = DayOfWeek.Monday.AddDays(5);

            Assert.AreEqual(DayOfWeek.Saturday, result);
        }

        [Test]
        public void AddDays_8DaysOnMonday_Expect_Tuesday()
        {
            var result = DayOfWeek.Monday.AddDays(8);

            Assert.AreEqual(DayOfWeek.Tuesday, result);
        }

        [Test]
        public void AddDays_Negative1DayOnMonday_Expect_Sunday()
        {
            var result = DayOfWeek.Monday.AddDays(-1);

            Assert.AreEqual(DayOfWeek.Sunday, result);
        }

        [Test]
        public void AddDays_Negative5DayOnMonday_Expect_Wednesday()
        {
            var result = DayOfWeek.Monday.AddDays(-5);

            Assert.AreEqual(DayOfWeek.Wednesday, result);
        }

        [Test]
        public void AddDays_Negative8DayOnMonday_Expect_Sunday()
        {
            var result = DayOfWeek.Monday.AddDays(-8);

            Assert.AreEqual(DayOfWeek.Sunday, result);
        }

        [Test]
        public void AddDays_0DayOnMonday_Expect_Monday()
        {
            var result = DayOfWeek.Monday.AddDays(0);

            Assert.AreEqual(DayOfWeek.Monday, result);
        }

        [Test]
        public void AddDays_7DaysOnMonday_Expect_Monday()
        {
            var result = DayOfWeek.Monday.AddDays(7);

            Assert.AreEqual(DayOfWeek.Monday, result);
        }

        [Test]
        public void AddDays_1DayOnSunday_Expect_Monday()
        {
            var result = DayOfWeek.Sunday.AddDays(1);

            Assert.AreEqual(DayOfWeek.Monday, result);
        }

        [Test]
        public void AddDays_5DaysOnSunday_Expect_Friday()
        {
            var result = DayOfWeek.Sunday.AddDays(5);

            Assert.AreEqual(DayOfWeek.Friday, result);
        }

        [Test]
        public void AddDays_8DaysOnSunday_Expect_Monday()
        {
            var result = DayOfWeek.Sunday.AddDays(8);

            Assert.AreEqual(DayOfWeek.Monday, result);
        }

        [Test]
        public void AddDays_Negative1DayOnSunday_Expect_Saturday()
        {
            var result = DayOfWeek.Sunday.AddDays(-1);

            Assert.AreEqual(DayOfWeek.Saturday, result);
        }

        [Test]
        public void AddDays_Negative5DayOnSunday_Expect_Tuesday()
        {
            var result = DayOfWeek.Sunday.AddDays(-5);

            Assert.AreEqual(DayOfWeek.Tuesday, result);
        }

        [Test]
        public void AddDays_Negative8DayOnSunday_Expect_Saturday()
        {
            var result = DayOfWeek.Sunday.AddDays(-8);

            Assert.AreEqual(DayOfWeek.Saturday, result);
        }

        [Test]
        public void AddDays_0DayOnSunday_Expect_Sunday()
        {
            var result = DayOfWeek.Sunday.AddDays(0);

            Assert.AreEqual(DayOfWeek.Sunday, result);
        }

        [Test]
        public void AddDays_7DaysOnSunday_Expect_Sunday()
        {
            var result = DayOfWeek.Sunday.AddDays(7);

            Assert.AreEqual(DayOfWeek.Sunday, result);
        }

        [Test]
        public void AddDays_1DayOnSaturday_Expect_Sunday()
        {
            var result = DayOfWeek.Saturday.AddDays(1);

            Assert.AreEqual(DayOfWeek.Sunday, result);
        }

        [Test]
        public void AddDays_5DaysOnSaturday_Expect_Thursday()
        {
            var result = DayOfWeek.Saturday.AddDays(5);

            Assert.AreEqual(DayOfWeek.Thursday, result);
        }

        [Test]
        public void AddDays_8DaysOnSaturday_Expect_Sunday()
        {
            var result = DayOfWeek.Saturday.AddDays(8);

            Assert.AreEqual(DayOfWeek.Sunday, result);
        }

        [Test]
        public void AddDays_Negative1DayOnSaturday_Expect_Friday()
        {
            var result = DayOfWeek.Saturday.AddDays(-1);

            Assert.AreEqual(DayOfWeek.Friday, result);
        }

        [Test]
        public void AddDays_Negative5DayOnSaturday_Expect_Monday()
        {
            var result = DayOfWeek.Saturday.AddDays(-5);

            Assert.AreEqual(DayOfWeek.Monday, result);
        }

        [Test]
        public void AddDays_Negative8DayOnSaturday_Expect_Friday()
        {
            var result = DayOfWeek.Saturday.AddDays(-8);

            Assert.AreEqual(DayOfWeek.Friday, result);
        }

        [Test]
        public void AddDays_0DayOnSaturday_Expect_Saturday()
        {
            var result = DayOfWeek.Saturday.AddDays(0);

            Assert.AreEqual(DayOfWeek.Saturday, result);
        }

        [Test]
        public void AddDays_7DaysOnSaturday_Expect_Saturday()
        {
            var result = DayOfWeek.Saturday.AddDays(7);

            Assert.AreEqual(DayOfWeek.Saturday, result);
        }
    }
}
