using Cognophile.Toolblox.Blocks.Statics.Strings;
using Cognophile.Toolblox.Blocks.Statics.Boolean;

namespace Cognophile.Toolblox
{
    public interface IToolblox
    {
        public static StringBlock Strings { get; }
        public static BooleanBlock Booleans { get; }
    }
}
