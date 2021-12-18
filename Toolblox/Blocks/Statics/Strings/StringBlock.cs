using System;
using Toolblox.Blocks.Base.Strings;

namespace Toolblox.Blocks.Statics.Strings
{
    public class StringBlock : IStringBlock
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
