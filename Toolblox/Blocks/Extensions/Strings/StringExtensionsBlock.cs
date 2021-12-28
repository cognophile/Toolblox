using System;
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
        /// Determines whether the given subject is null or empty.
        /// </summary>
        /// <param name="subject">The string upon which to assert the behaviour of the method.</param>
        /// <returns>Boolean indicating whether the called-upon string is null or empty.</returns>
        public static bool IsNullOrEmpty(this string subject)
        {
            return StringBaseBlock.IsNullOrEmpty(subject);
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
    }
}
