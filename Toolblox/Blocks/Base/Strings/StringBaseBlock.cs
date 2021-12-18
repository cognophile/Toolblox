using System;

namespace Cognophile.Toolblox.Blocks.Base.Strings
{
    public static class StringBaseBlock
    {
        public static bool IsNull(string subject)
        {
            return subject is null;
        }

        public static bool IsNullOrEmpty(string subject)
        {
            return string.IsNullOrEmpty(subject);
        }

        public static bool IsNullOrWhitespace(string subject)
        {
            return string.IsNullOrWhiteSpace(subject);
        }
    }
}
