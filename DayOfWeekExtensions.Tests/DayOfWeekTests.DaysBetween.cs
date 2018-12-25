using System;
using System.Linq;
using NUnit.Framework;

namespace DayOfWeekExtensions.Tests
{
    partial class DayOfWeekTests
    {
        [Test]
        public void GetDaysBetween_MondayToFriday_Expect_MondayTuesdayWednesdayThursdayFriday()
        {
            var result = DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Friday);

            CollectionAssert.AreEqual(new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
                                              DayOfWeek.Thursday, DayOfWeek.Friday }, result);
        }

        [Test]
        public void GetDaysBetween_MondayToFridayWithoutBoundary_Expect_TuesdayWednesdayThursday()
        {
            var result = DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Friday, includeBoundary: false);

            CollectionAssert.AreEqual(new[] { DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday }, result);
        }

        [Test]
        public void GetDaysBetween_FridayToMonday_Expect_FridaySaturdaySundayMonday()
        {
            var result = DayOfWeek.Friday.GetDaysBetween(DayOfWeek.Monday);

            CollectionAssert.AreEqual(new[] { DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday,
                                              DayOfWeek.Monday }, result);
        }

        [Test]
        public void GetDaysBetween_FridayToMondayWithoutBoundary_Expect_SaturdaySunday()
        {
            var result = DayOfWeek.Friday.GetDaysBetween(DayOfWeek.Monday, includeBoundary: false);

            CollectionAssert.AreEqual(new[] { DayOfWeek.Saturday, DayOfWeek.Sunday }, result);
        }

        [Test]
        public void GetDaysBetween_MondayToTuesday_Expect_MondayTuesday()
        {
            var result = DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Tuesday);

            CollectionAssert.AreEqual(new[] { DayOfWeek.Monday, DayOfWeek.Tuesday }, result);
        }

        [Test]
        public void GetDaysBetween_MondayToTuesdayWithoutBoundary_Expect_EmptyCollection()
        {
            var result = DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Tuesday, includeBoundary: false);

            CollectionAssert.AreEqual(Enumerable.Empty<DayOfWeek>(), result);
        }

        [Test]
        public void GetDaysBetween_MondayToMonday_Expect_Monday()
        {
            var result = DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Monday);

            CollectionAssert.AreEqual(new[] { DayOfWeek.Monday }, result);
        }

        [Test]
        public void GetDaysBetween_MondayToMondayWithoutBoundary_Expect_EmptyCollection()
        {
            var result = DayOfWeek.Monday.GetDaysBetween(DayOfWeek.Monday, includeBoundary: false);

            CollectionAssert.AreEqual(Enumerable.Empty<DayOfWeek>(), result);
        }
    }
}
