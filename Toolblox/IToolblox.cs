using Cognophile.Toolblox.Blocks.Statics.Strings;
using Cognophile.Toolblox.Blocks.Statics.Boolean;
using Cognophile.Toolblox.Blocks.Statics.Collections;
using Cognophile.Toolblox.Blocks.Statics.Dates;
using Cognophile.Toolblox.Blocks.Statics.Json;
using Cognophile.Toolblox.Blocks.Statics.Numbers;
using Cognophile.Toolblox.Blocks.Statics.Objects;

namespace Cognophile.Toolblox
{
    public interface IToolblox
    {
        public static StringBlock Strings { get; }
        public static BooleanBlock Booleans { get; }
        public static CollectionsBlock Collections { get; }
        public static DateBlock Dates { get; }
        public static JsonBlock Json { get; }
        public static NumbersBlock Numbers { get; }
        public static ObjectBlock Objects { get; }
    }
}
