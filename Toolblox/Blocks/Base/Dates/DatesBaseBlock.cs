using System;
using Cognophile.Toolblox.Blocks.Extensions.Strings;

namespace Cognophile.Toolblox.Blocks.Base.Dates
{
    public static class DatesBaseBlock
    {
        /// <summary>
        /// Determines whether the subject is a date in the past
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsPast(DateTime subject)
        {
            return subject < DateTime.UtcNow;
        }

        /// <summary>
        /// Determines whether the subject is equal to today's date
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsToday(DateTime subject)
        {
            return subject.Date == DateTime.Now.Date;
        }

        /// <summary>
        /// Determines whether the subject is a date in the future
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsFuture(DateTime subject)
        {
            return subject > DateTime.UtcNow;
        }

        /// <summary>
        /// Determines whether the subject came before the given comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsBefore(DateTime subject, DateTime comparitor)
        {
            return subject < comparitor;
        }

        /// <summary>
        /// Determines whether the subject comes after the given comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsAfter(DateTime subject, DateTime comparitor)
        {
            return subject > comparitor;
        }

        /// <summary>
        /// Determines whether the subject is equal to the provided comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsEqual(DateTime subject, DateTime comparitor)
        {
            return subject == comparitor;
        }

        /// <summary>
        /// Converts the subject to a unix timestamp
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>The equivelent unix representation</returns>
        public static long ToUnix(DateTime subject)
        {
            return ((DateTimeOffset)subject).ToUnixTimeSeconds();
        }

        /// <summary>
        /// Formats the subject as the given pattern
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="pattern"></param>
        /// <returns>The subject DateTime in the requested format</returns>
        public static string FormatAs(DateTime subject, string pattern)
        {
            if (pattern.IsNullOrWhitespace()) return subject.ToString();
            return subject.ToString(pattern);
        }
    }
}
