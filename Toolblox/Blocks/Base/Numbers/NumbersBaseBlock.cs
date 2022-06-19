using System;
using System.Globalization;
using System.Threading;

namespace Cognophile.Toolblox.Blocks.Base.Numbers
{
    public static class NumbersBaseBlock
    {
        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(int subject)
        {
            return subject.Equals(0);
        }

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(double subject)
        {
            return subject.Equals(0);
        }

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(decimal subject)
        {
            return subject.Equals(0);
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(int subject)
        {
            return subject > 0;
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(double subject)
        {
            return subject > 0;
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(decimal subject)
        {
            return subject > 0;
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(int subject)
        {
            return subject < 0;
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(double subject)
        {
            return subject < 0;
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(decimal subject)
        {
            return subject < 0;
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="threshold"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(int subject, int threshold)
        {
            return threshold > subject;
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="threshold"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(double subject, double threshold)
        {
            return threshold > subject;
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="threshold"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(decimal subject, decimal threshold)
        {
            return threshold > subject;
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="threshold"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(int subject, int threshold)
        {
            return threshold < subject;
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="threshold"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(double subject, double threshold)
        {
            return threshold < subject;
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="threshold"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(decimal subject, decimal threshold)
        {
            return threshold < subject;
        }

        /// <summary>
        /// Determines whether the subject's value is divisable by the given divisor
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="divisor"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsDivisibleBy(int subject, int divisor)
        {
            return subject % divisor == 0;
        }

        /// <summary>
        /// Determines whether the subject's value is a multiple of by the given multiplier
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="multiplier"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsMultipleOf(int subject, int multiplier)
        {
            return subject % multiplier == 0;
        }

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
        public static string AsCurrency(int subject, string culture = null)
        {
            if (culture is null)
            {
                culture = Thread.CurrentThread.CurrentCulture.Name;
            }

            return subject.ToString("C", CultureInfo.CreateSpecificCulture(culture));
        }

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
        public static string AsCurrency(double subject, string culture = null)
        {
            if (culture is null)
            {
                culture = Thread.CurrentThread.CurrentCulture.Name;
            }

            return subject.ToString("C", CultureInfo.CreateSpecificCulture(culture));
        }

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
        public static string AsCurrency(decimal subject, string culture = null)
        {
            if (culture is null)
            {
                culture = Thread.CurrentThread.CurrentCulture.Name;
            }

            return subject.ToString("C", CultureInfo.CreateSpecificCulture(culture));
        }
    }
}
