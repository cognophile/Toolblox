using System;
using Cognophile.Toolblox.Blocks.Base.Strings;

namespace Cognophile.Toolblox.Blocks.Statics.Strings
{
    public sealed class StringBlock : IStringBlock
    {
        public bool IsNull(string subject)
        {
            return StringBaseBlock.IsNull(subject);
        }

        public bool IsNullOrEmpty(string subject)
        {
            return StringBaseBlock.IsNullOrEmpty(subject);
        }

        public bool IsNullOrWhitespace(string subject)
        {
            return StringBaseBlock.IsNullOrWhitespace(subject);
        }
    }
}
