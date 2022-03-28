using System;

namespace Toolblox.Blocks.Base.Dates
{
    public static class DatesBaseBlock
    {
        public static bool IsPast(DateTime subject)
        {
            return subject < DateTime.UtcNow;
        }

        public static bool IsToday(DateTime subject)
        {
            return subject.Date == DateTime.UtcNow.Date;
        }

        public static bool IsFuture(DateTime subject)
        {
            return subject > DateTime.UtcNow;
        }

        public static bool IsBefore(DateTime subject, DateTime comparitor)
        {
            return subject < comparitor;
        }

        public static bool IsAfter(DateTime subject, DateTime comparitor)
        {
            return subject > comparitor;
        }

        public static bool IsEqual(DateTime subject, DateTime comparitor)
        {
            return subject == comparitor;
        }

        public static long ToUnix(DateTime subject)
        {
            return ((DateTimeOffset)subject).ToUnixTimeSeconds();
        }

        public static string FormatAs(DateTime subject, string pattern)
        {
            return subject.ToString(pattern);
        }
    }
}
