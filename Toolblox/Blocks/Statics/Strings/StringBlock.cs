using System.Collections.Generic;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Strings;

namespace Cognophile.Toolblox.Blocks.Statics.Strings
{
    public sealed class StringBlock : IBlock
    {
        /// <summary>
        /// Determines whether the given subject is null.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNull(string subject) => StringBaseBlock.IsNull(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is empty.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsEmpty(string subject) => StringBaseBlock.IsEmpty(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is null or empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null or empty.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNullOrEmpty(string subject) => StringBaseBlock.IsNullOrEmpty(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is whitespace.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is whitespace.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsWhitespace(string subject) => StringBaseBlock.IsWhitespace(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is null, empty, or whitespace.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null, empty, or whitespace.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNullOrWhitespace(string subject) => StringBaseBlock.IsNullOrWhitespace(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject has title casing.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string has title casing.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsTitlecase(string subject) => StringBaseBlock.IsTitlecase(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the first character of the given string is uppercase.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string has an upper case first character.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsCapitalised(string subject) => StringBaseBlock.IsCapitalised(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is formed of alpha-only characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only alpha characters.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsAlpha(string subject) => StringBaseBlock.IsAlpha(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is formed of numeric-only characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only numeric characters.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNumeric(string subject) => StringBaseBlock.IsNumeric(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is formed of symbol-only characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only symbolic characters.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsSymbols(string subject) => StringBaseBlock.IsSymbols(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is formed of only numeric or symbol characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains only numeric or symbolic characters.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNumericSymbols(string subject) => StringBaseBlock.IsNumericSymbols(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is formed of alphanumeric characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains alphanumeric characters.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsAlphaNumeric(string subject) => StringBaseBlock.IsAlphaNumeric(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is formed of alphanumeric or symbol characters.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string contains alphanumeric or symbol characters.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsAlphaNumericSymbols(string subject) => StringBaseBlock.IsAlphaNumericSymbols(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject matches the given regex pattern.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <param name="pattern">The Regex pattern to inspect the string against.</param>
        /// <returns>Boolean indicating whether the called-upon string matches the given regex pattern.</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool Matches(string subject, string pattern) => StringBaseBlock.Matches(subject, pattern);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is Null or Empty
        /// </summary>
        /// <param name="subject"><The string upon which to assert the behaviour of the method./param>
        /// <returns>When null or empty, then returns null. When populated, then returns the subject.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string AsNullWhenEmpty(string subject) => StringBaseBlock.AsNullWhenEmpty(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the given subject is Null, Empty, or Whitespace
        /// </summary>
        /// <param name="subject"><The string upon which to assert the behaviour of the method./param>
        /// <returns>When null, empty, or whitespace, then returns null. When populated, then returns the subject.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string AsNullWhenWhitespace(string subject) => StringBaseBlock.AsNullWhenWhitespace(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Retrieves the section of the string located between the given bookends.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <param name="left">The string to start the subsection at.</param>
        /// <param name="right">The string to end the subsection at.</param>
        /// <returns>String representing the substring located between the bookends. Returns empty if a matching section cannot be found.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string Between(string subject, string left, string right) => StringBaseBlock.Between(subject, left, right);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Explode the given string into a collection, delimited by the given separator(s).
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <param name="separators">The array of separators to split the string by.</param>
        /// <returns>Collection of substrings representing the delimiter exploded string.</returns>
#pragma warning disable CA1822 // Mark members as static
        public ICollection<string> Explode(string subject, char separator) => StringBaseBlock.Explode(subject, separator);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Implode the given collection of strings to a single string using the given separator.
        /// </summary>
        /// <param name="substrings">The substrings to be joined together.</param>
        /// <param name="separator">The delimiter character to join the strings by.</param>
        /// <returns>String representing the concatenated strings with the given seperator.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string Implode(ICollection<string> substrings, char separator) => StringBaseBlock.Implode(substrings, separator);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Convert the given string to title case.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <returns>The given string in title case.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string Titlecase(string subject) => StringBaseBlock.Titlecase(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Convert the given string to have a capitalised first character.
        /// </summary>
        /// <param name="subject">The string upon which the method should operate.</param>
        /// <returns>The given string with the initial character capitalised.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string Capitalise(string subject) => StringBaseBlock.Capitalise(subject);
#pragma warning restore CA1822 // Mark members as static
    }
}