using Cognophile.Toolblox.Blocks.Base.Numbers;

namespace Cognophile.Toolblox.Blocks.Statics.Numbers
{
    public static class NumbersBlock
    {
        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(int subject)
        {
            return NumbersBaseBlock.IsZero(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(double subject)
        {
            return NumbersBaseBlock.IsZero(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsZero(decimal subject)
        {
            return NumbersBaseBlock.IsZero(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(int subject)
        {
            return NumbersBaseBlock.IsPositive(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(double subject)
        {
            return NumbersBaseBlock.IsPositive(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsPositive(decimal subject)
        {
            return NumbersBaseBlock.IsPositive(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(int subject)
        {
            return NumbersBaseBlock.IsNegative(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(double subject)
        {
            return NumbersBaseBlock.IsNegative(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsNegative(decimal subject)
        {
            return NumbersBaseBlock.IsNegative(subject);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(int subject, int threshold)
        {
            return NumbersBaseBlock.IsLessThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(double subject, double threshold)
        {
            return NumbersBaseBlock.IsLessThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsLessThan(decimal subject, decimal threshold)
        {
            return NumbersBaseBlock.IsLessThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(int subject, int threshold)
        {
            return NumbersBaseBlock.IsGreaterThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(double subject, double threshold)
        {
            return NumbersBaseBlock.IsGreaterThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsGreaterThan(decimal subject, decimal threshold)
        {
            return NumbersBaseBlock.IsGreaterThan(subject, threshold);
        }

        /// <summary>
        /// Determines whether the subject's value is divisable by the given divisor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsDivisibleBy(int subject, int divisor)
        {
            return NumbersBaseBlock.IsDivisibleBy(subject, divisor);
        }

        /// <summary>
        /// Determines whether the subject's value is a multiple of by the given multiplier
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
        public static bool IsMultipleOf(int subject, int multiplier)
        {
            return NumbersBaseBlock.IsMultipleOf(subject, multiplier);
        }

        /// <summary>
        /// Attempts to parses the given numeric value to the given type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <returns>The value converted to the required type</returns>
        public static T ParseAs<T>(object subject)
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
        public static string AsCurrency(int subject, string culture = null)
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
        public static string AsCurrency(double subject, string culture = null)
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
        public static string AsCurrency(decimal subject, string culture = null)
        {
            return NumbersBaseBlock.AsCurrency(subject, culture);
        }
    }
}
