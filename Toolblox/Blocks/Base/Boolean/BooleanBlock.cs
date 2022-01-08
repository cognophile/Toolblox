using System;
namespace Toolblox.Blocks.Base.Boolean
{
    public static class BooleanBlock
    {
        public static string ToTextual(bool subject)
        {
            return subject ? "Yes" : "No";
        }
    }
}
