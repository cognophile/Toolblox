using Cognophile.Toolblox.Blocks.Base.Numbers;

namespace Cognophile.Toolblox.Blocks.Extensions.Numbers
{
    public static class NumbersExtensionBlock
    {
        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(this int subject)
        {
            return NumbersBaseBlock.IsZero(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(this double subject)
        {
            return NumbersBaseBlock.IsZero(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(this decimal subject)
        {
            return NumbersBaseBlock.IsZero(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(this int subject)
        {
            return NumbersBaseBlock.IsPositive(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(this double subject)
        {
            return NumbersBaseBlock.IsPositive(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(this decimal subject)
        {
            return NumbersBaseBlock.IsPositive(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(this int subject)
        {
            return NumbersBaseBlock.IsNegative(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(this double subject)
        {
            return NumbersBaseBlock.IsNegative(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(this decimal subject)
        {
            return NumbersBaseBlock.IsNegative(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(this int subject, int threshold)
        {
            return NumbersBaseBlock.IsLessThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(this double subject, double threshold)
        {
            return NumbersBaseBlock.IsLessThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(this decimal subject, decimal threshold)
        {
            return NumbersBaseBlock.IsLessThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(this int subject, int threshold)
        {
            return NumbersBaseBlock.IsGreaterThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(this double subject, double threshold)
        {
            return NumbersBaseBlock.IsGreaterThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(this decimal subject, decimal threshold)
        {
            return NumbersBaseBlock.IsGreaterThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is divisable by the given divisor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsDivisibleBy(this int subject, int divisor)
        {
            return NumbersBaseBlock.IsDivisibleBy(subject, divisor);
        }

        /// <summary>
        /// Determines whether the subject's value is a multiple of by the given multiplier
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsMultipleOf(this int subject, int multiplier)
        {
            return NumbersBaseBlock.IsMultipleOf(subject, multiplier);
        }

        /// <summary>
        /// Attempts to parses the given numeric value to the given type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <returns>The value converted to the required type</returns>
        public static T ParseAs<T>(this object subject)
        {
            return NumbersBaseBlock.ParseAs<T>(subject);
        }

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
        public static string AsCurrency(this int subject, string culture = null)
        {
            return NumbersBaseBlock.AsCurrency(subject, culture);
        }

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
        public static string AsCurrency(this double subject, string culture = null)
        {
            return NumbersBaseBlock.AsCurrency(subject, culture);
        }

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
        public static string AsCurrency(this decimal subject, string culture = null)
        {
            return NumbersBaseBlock.AsCurrency(subject, culture);
        }
    }
}
