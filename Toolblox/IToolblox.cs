using Cognophile.Toolblox.Blocks.Statics.Boolean;
using Cognophile.Toolblox.Blocks.Statics.Collections;
using Cognophile.Toolblox.Blocks.Statics.Dates;
using Cognophile.Toolblox.Blocks.Statics.Json;
using Cognophile.Toolblox.Blocks.Statics.Numbers;
using Cognophile.Toolblox.Blocks.Statics.Objects;
using Cognophile.Toolblox.Blocks.Statics.Strings;

namespace Cognophile.Toolblox
{
    public interface IToolblox
    {
        /// <summary>
        /// Access to common string-based extension behaviours.
        /// </summary>
        public StringBlock StringBlock { get; }

        /// <summary>
        /// Access to common boolean-based extension behaviours.
        /// </summary>
        public BooleanBlock BooleanBlock { get; }

        /// <summary>
        /// Access to common collection-based extension behaviours.
        /// </summary>
        public CollectionsBlock CollectionBlock { get; }

        /// <summary>
        /// Access to common date-based extension behaviours.
        /// </summary>
        public DateBlock DateBlock { get; }

        /// <summary>
        /// Access to common json-based extension behaviours.
        /// </summary>
        public JsonBlock JsonBlock { get; }

        /// <summary>
        /// Access to common numeric-based extension behaviours.
        /// </summary>
        public NumbersBlock NumberBlock { get; }

        /// <summary>
        /// Access to common object-based extension behaviours.
        /// </summary>
        public ObjectBlock ObjectBlock { get; }
    }
}
