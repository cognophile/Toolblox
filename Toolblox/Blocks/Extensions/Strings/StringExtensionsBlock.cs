using System;
using Toolblox.Blocks.Base.Strings;

namespace Toolblox.Blocks.Extensions.Strings
{
    public static class StringExtensionsBlock
    {
        public static bool IsNull(this string subject)
        {
            return StringBaseBlock.IsNull(subject);
        }

        public static bool IsNullOrEmpty(this string subject)
        {
            return StringBaseBlock.IsNullOrEmpty(subject);
        }

        public static bool IsNullOrWhitespace(this string subject)
        {
            return StringBaseBlock.IsNullOrWhitespace(subject);
        }
    }
}
