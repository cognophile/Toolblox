using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Numbers;

namespace Cognophile.Toolblox.Blocks.Statics.Numbers
{
    public class NumbersBlock : IBlock
    {
        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsZero(int subject) => NumbersBaseBlock.IsZero(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsZero(double subject) => NumbersBaseBlock.IsZero(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is zero
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsZero(decimal subject) => NumbersBaseBlock.IsZero(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsPositive(int subject) => NumbersBaseBlock.IsPositive(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is positive
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsPositive(double subject) => NumbersBaseBlock.IsPositive(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsPositive(decimal subject) => NumbersBaseBlock.IsPositive(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNegative(int subject) => NumbersBaseBlock.IsNegative(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is negative
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNegative(double subject) => NumbersBaseBlock.IsNegative(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNegative(decimal subject) => NumbersBaseBlock.IsNegative(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsLessThan(int subject, int threshold) => NumbersBaseBlock.IsLessThan(subject, threshold);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsLessThan(double subject, double threshold) => NumbersBaseBlock.IsLessThan(subject, threshold);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is less than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsLessThan(decimal subject, decimal threshold) => NumbersBaseBlock.IsLessThan(subject, threshold);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsGreaterThan(int subject, int threshold) => NumbersBaseBlock.IsGreaterThan(subject, threshold);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsGreaterThan(double subject, double threshold) => NumbersBaseBlock.IsGreaterThan(subject, threshold);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is greater than the given threshold
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsGreaterThan(decimal subject, decimal threshold) => NumbersBaseBlock.IsGreaterThan(subject, threshold);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is divisable by the given divisor
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsDivisibleBy(int subject, int divisor) => NumbersBaseBlock.IsDivisibleBy(subject, divisor);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the subject's value is a multiple of by the given multiplier
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value representing whether the subject passes the condition</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsMultipleOf(int subject, int multiplier) => NumbersBaseBlock.IsMultipleOf(subject, multiplier);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
#pragma warning disable CA1822 // Mark members as static
        public string AsCurrency(int subject, string culture = null) => NumbersBaseBlock.AsCurrency(subject, culture);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
#pragma warning disable CA1822 // Mark members as static
        public string AsCurrency(double subject, string culture = null) => NumbersBaseBlock.AsCurrency(subject, culture);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Parses the subject's value to the local currency, by default.
        ///     Optionally, the culture can be overriden. 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="culture"></param>
        /// <returns>The numeric value as a local currency string</returns>
#pragma warning disable CA1822 // Mark members as static
        public string AsCurrency(decimal subject, string culture = null) => NumbersBaseBlock.AsCurrency(subject, culture);
#pragma warning restore CA1822 // Mark members as static
    }
}
