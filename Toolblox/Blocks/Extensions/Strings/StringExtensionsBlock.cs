using System.Collections.Generic;
using Cognophile.Toolblox.Blocks.Base.Strings;

namespace Cognophile.Toolblox.Blocks.Extensions.Strings
{
    public static class StringExtensionsBlock
    {
        /// <summary>
        /// Determines whether the given subject is null.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null.</returns>
        public static bool IsNull(this string subject)
        {
            return StringBaseBlock.IsNull(subject);
        }

        /// <summary>
        /// Determines whether the given subject is empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is empty.</returns>
        public static bool IsEmpty(this string subject)
        {
            return StringBaseBlock.IsEmpty(subject);
        }

        /// <summary>
        /// Determines whether the given subject is null or empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null or empty.</returns>
        public static bool IsNullOrEmpty(this string subject)
        {
            return StringBaseBlock.IsNullOrEmpty(subject);
        }

        /// <summary>
        /// Determines whether the given subject is whitespace.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is whitespace.</returns>
        public static bool IsWhitespace(this string subject)
        {
            return StringBaseBlock.IsWhitespace(subject);
        }

        /// <summary>
        /// Determines whether the given subject is null, empty, or whitespace.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null, empty, or whitespace.</returns>
        public static bool IsNullOrWhitespace(this string subject)
        {
            return StringBaseBlock.IsNullOrWhitespace(subject);
        }

        /// <summary>
        /// Determines whether the given subject has title casing.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string has title casing.</returns>
        public static bool IsTitlecase(this string subject)
        {
            return StringBaseBlock.IsTitlecase(subject);
        }

        /// <summary>
        /// Determines whether the first character of the given string is uppercase.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string has an upper case first character.</returns>
        public static bool IsCapitalised(this string subject)
        {
            return StringBaseBlock.IsCapitalised(subject);
        }

        /// <summary>
        /// Determines whether the given subject is formed of alpha-only characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only alpha characters.</returns>
        public static bool IsAlpha(this string subject)
        {
            return StringBaseBlock.IsAlpha(subject);
        }

        /// <summary>
        /// Determines whether the given subject is formed of numeric-only characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only numeric characters.</returns>
        public static bool IsNumeric(this string subject)
        {
            return StringBaseBlock.IsNumeric(subject);
        }

        /// <summary>
        /// Determines whether the given subject is formed of symbol-only characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only symbolic characters.</returns>
        public static bool IsSymbols(this string subject)
        {
            return StringBaseBlock.IsSymbols(subject);
        }

        /// <summary>
        /// Determines whether the given subject is formed of only numeric or symbol characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only numeric or symbolic characters.</returns>
        public static bool IsNumericSymbols(this string subject)
        {
            return StringBaseBlock.IsNumericSymbols(subject);
        }

        /// <summary>
        /// Determines whether the given subject is formed of alphanumeric characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains alphanumeric characters.</returns>
        public static bool IsAlphaNumeric(this string subject)
        {
            return StringBaseBlock.IsAlphaNumeric(subject);
        }

        /// <summary>
        /// Determines whether the given subject is formed of alphanumeric or symbol characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains alphanumeric or symbol characters.</returns>
        public static bool IsAlphaNumericSymbols(this string subject)
        {
            return StringBaseBlock.IsAlphaNumericSymbols(subject);
        }

        /// <summary>
        /// Determines whether the given subject matches the given regex pattern.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <param name="pattern">The Regex pattern to inspect the string against.</param>
        /// <returns>Boolean indicating whether the called-upon string matches the given regex pattern.</returns>
        public static bool Matches(this string subject, string pattern)
        {
            return StringBaseBlock.Matches(subject, pattern);
        }

        /// <summary>
        /// Retrieves the section of the string located between the given bookends.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <param name="left">The string to start the subsection at.</param>
        /// <param name="right">The string to end the subsection at.</param>
        /// <returns>String representing the substring located between the bookends. Returns empty if a matching section cannot be found.</returns>
        public static string Between(this string subject, string left, string right)
        {
            return StringBaseBlock.Between(subject, left, right);
        }

        /// <summary>
        /// Explode the given string into a collection, delimited by the given separator(s).
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <param name="separators">The array of separators to split the string by.</param>
        /// <returns>Collection of substrings representing the delimiter exploded string.</returns>
        public static ICollection<string> Explode(this string subject, char separator)
        {
            return StringBaseBlock.Explode(subject, separator);
        }

        /// <summary>
        /// Convert the given string to title case.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <returns>The given string in title case.</returns>
        public static string Titlecase(this string subject)
        {
            return StringBaseBlock.Titlecase(subject);
        }

        /// <summary>
        /// Convert the given string to have a capitalised first character.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <returns>The given string with the initial character capitalised.</returns>
        public static string Capitalise(this string subject)
        {
            return StringBaseBlock.Capitalise(subject);
        }
    }
}