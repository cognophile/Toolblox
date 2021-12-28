using System;
using System.Collections.Generic;
using Cognophile.Toolblox.Blocks.Base.Strings;

namespace Cognophile.Toolblox.Blocks.Statics.Strings
{
    public sealed class StringBlock
    {
        /// <summary>
        /// Determines whether the given subject is null.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null.</returns>
        public static bool IsNull(string subject)
        {
            return StringBaseBlock.IsNull(subject);
        }

        /// <summary>
        /// Determines whether the given subject is empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is empty.</returns>
        public static bool IsEmpty(string subject)
        {
            return StringBaseBlock.IsEmpty(subject);
        }

        /// <summary>
        /// Determines whether the given subject is null or empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null or empty.</returns>
        public static bool IsNullOrEmpty(string subject)
        {
            return StringBaseBlock.IsNullOrEmpty(subject);
        }

        /// <summary>
        /// Determines whether the given subject is whitespace.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is whitespace.</returns>
        public static bool IsWhitespace(string subject)
        {
            return StringBaseBlock.IsWhitespace(subject);
        }

        /// <summary>
        /// Determines whether the given subject is null, empty, or whitespace.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null, empty, or whitespace.</returns>
        public static bool IsNullOrWhitespace(string subject)
        {
            return StringBaseBlock.IsNullOrWhitespace(subject);
        }

        /// <summary>
        /// Determines whether the given subject is has title casing.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string has title casing.</returns>
        public static bool IsTitlecase(string subject)
        {
            return StringBaseBlock.IsTitlecase(subject);
        }

        /// <summary>
        /// Determines whether the given subject matches the given regex pattern.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string matches the given regex pattern.</returns>
        public static bool Matches(string subject, string pattern)
        {
            return StringBaseBlock.Matches(subject, pattern);
        }

        /// <summary>
        /// Determines whether the given subject contains the given substring.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains the given substring.</returns>
        public static bool Contains(string haystack, string needle)
        {
            return StringBaseBlock.Contains(haystack, needle);
        }

        /// <summary>
        /// Retrieves the section of the string located between the given bookends.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate..</param>
        /// <param name="left">The string to start the subsection at.</param>
        /// <param name="right">The string the end the subsection at.</param>
        /// <returns>String representing the substring located between the bookends. Returns empty if a matching section cannot be found.</returns>
        public static string Between(string subject, string left, string right)
        {
            return StringBaseBlock.Between(subject, left, right);
        }

        /// <summary>
        /// Explode the given string into a collection, delimited by the given seperator(s).
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <param name="separators">The array of seperators to split the string by.</param>
        /// <returns>Collection of substrings representing the delimiter exploded string.</returns>
        public static ICollection<string> Explode(string subject, char[] separators)
        {
            return StringBaseBlock.Explode(subject, separators);
        }

        /// <summary>
        /// Implode the given collection of strings to a single string using the given serperator.
        /// </summary>
        /// <param name="separator">The delimiter charater to join the strings by.</param>
        /// <param name="substrings">The substrings to be joined together.</param>
        /// <returns>String representing the concatenated strings with the given seperator.</returns>
        public static string Implode(char separator, ICollection<string> substrings)
        {
            return StringBaseBlock.Implode(separator, substrings);
        }

        /// <summary>
        /// Convert the given string to title case.
        /// </summary>
        /// <param name="subject">he string upon which the method should operate.</param>
        /// <returns>The given string in title case.</returns>
        public static string MakeTitlecase(string subject)
        {
            return StringBaseBlock.MakeTitlecase(subject);
        }
    }
}
