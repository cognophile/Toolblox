using System;
using Cognophile.Toolblox.Blocks.Base.Dates;

namespace Cognophile.Toolblox.Blocks.Extensions.Dates
{
    public static class DatesExtensionBlock
    {
        /// <summary>
        /// Determines whether the subject is a date in the past
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsPast(this DateTime subject)
        {
            return DatesBaseBlock.IsPast(subject);
        }

        /// <summary>
        /// Determines whether the subject is equal to today's date
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsToday(this DateTime subject)
        {
            return DatesBaseBlock.IsToday(subject);
        }

        /// <summary>
        /// Determines whether the subject is a date in the future
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsFuture(this DateTime subject)
        {
            return DatesBaseBlock.IsFuture(subject);
        }

        /// <summary>
        /// Determines whether the subject came before the given comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsBefore(this DateTime subject, DateTime comparitor)
        {
            return DatesBaseBlock.IsBefore(subject, comparitor);
        }

        /// <summary>
        /// Determines whether the subject comes after the given comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsAfter(this DateTime subject, DateTime comparitor)
        {
            return DatesBaseBlock.IsAfter(subject, comparitor);
        }

        /// <summary>
        /// Determines whether the subject is equal to the provided comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
        public static bool IsEqual(this DateTime subject, DateTime comparitor)
        {
            return DatesBaseBlock.IsEqual(subject, comparitor);
        }

        /// <summary>
        /// Converts the subject to a unix timestamp
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>The equivelent unix representation</returns>
        public static long ToUnix(this DateTime subject)
        {
            return DatesBaseBlock.ToUnix(subject);
        }

        /// <summary>
        /// Formats the subject as the given pattern
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="pattern"></param>
        /// <returns>The subject DateTime in the requested format</returns>
        public static string FormatAs(this DateTime subject, string pattern)
        {
            return DatesBaseBlock.FormatAs(subject, pattern);
        }
    }
}
