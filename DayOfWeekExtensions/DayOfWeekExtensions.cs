using System;
using System.Collections.Generic;

namespace DayOfWeekExtensions
{
    public static class DayOfWeekExtensions
    {
        public static DayOfWeek AddDays(this DayOfWeek dayOfWeek, int value)
        {
            var numberOfDays = 7;

            var result = ((int)dayOfWeek + numberOfDays + value % numberOfDays) % numberOfDays;

            return (DayOfWeek)result;
        }

        public static IEnumerable<DayOfWeek> GetDaysBetween(this DayOfWeek from, DayOfWeek to, bool includeBoundary = true)
        {
            if (includeBoundary)
                yield return from;

            if (from != to)
            {
                var next = from.AddDays(1);

                while (next != to)
                {
                    yield return next;
                    next = next.AddDays(1);
                }
            }

            if (includeBoundary && from != to)
                yield return to;
        }
    }
}
