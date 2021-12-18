using System;
namespace Toolblox.Blocks.Statics.Strings
{
    public interface IStringBlock
    {
        bool IsNull(string subject);
        bool IsNullOrEmpty(string subject);
        bool IsNullOrWhitespace(string subject);
    }
}
