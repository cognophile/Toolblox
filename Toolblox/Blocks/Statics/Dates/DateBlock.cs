using System;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Dates;

namespace Cognophile.Toolblox.Blocks.Statics.Dates
{
    public sealed class DateBlock : IBlock
    {
        /// <summary>
        /// Determines whether the subject is a date in the past
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsPast(DateTime subject) => DatesBaseBlock.IsPast(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject is equal to today's date
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsToday(DateTime subject) => DatesBaseBlock.IsToday(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject is a date in the future
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsFuture(DateTime subject) => DatesBaseBlock.IsFuture(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject came before the given comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="comparitor"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsBefore(DateTime subject, DateTime comparitor) => DatesBaseBlock.IsBefore(subject, comparitor);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject comes after the given comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="comparitor"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsAfter(DateTime subject, DateTime comparitor) => DatesBaseBlock.IsAfter(subject, comparitor);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject is equal to the provided comparitor
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="comparitor"></param>
        /// <returns>Boolean representing the result of the temporal evaluation condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsEqual(DateTime subject, DateTime comparitor) => DatesBaseBlock.IsEqual(subject, comparitor);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Converts the subject to a unix timestamp
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>The equivelent unix representation</returns>
#pragma warning disable CA1822 // Mark members as static
        public long ToUnix(DateTime subject) => DatesBaseBlock.ToUnix(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Formats the subject as the given pattern
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="pattern"></param>
        /// <returns>The subject DateTime in the requested format</returns>
#pragma warning disable CA1822 // Mark members as static
        public string FormatAs(DateTime subject, string pattern) => DatesBaseBlock.FormatAs(subject, pattern);
#pragma warning restore CA1822 // Mark members as static
    }
}
