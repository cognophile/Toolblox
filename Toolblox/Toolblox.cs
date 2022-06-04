using Cognophile.Toolblox.Blocks.Statics.Boolean;
using Cognophile.Toolblox.Blocks.Statics.Collections;
using Cognophile.Toolblox.Blocks.Statics.Dates;
using Cognophile.Toolblox.Blocks.Statics.Json;
using Cognophile.Toolblox.Blocks.Statics.Numbers;
using Cognophile.Toolblox.Blocks.Statics.Objects;
using Cognophile.Toolblox.Blocks.Statics.Strings;

/// <summary>
/// Toolblox
/// A one-stop library for common utilities for developing .NET applications.
///
/// Copyright (c) cognophile 2021.
/// </summary>
namespace Cognophile.Toolblox
{
    /// <summary>
    /// Access the suite of the functionality provided by the library via this class
    ///   and its members.
    ///
    /// Alternative access to a select functionality set is also available via
    ///   the Extensions namespace of the library. 
    /// </summary>
    public class Toolblox : IToolblox
    {
        public Toolblox() { }

        /// <summary>
        /// Access to common string-based extension behaviours.
        /// </summary>
        public static StringBlock Strings { get; } = new();

        /// <summary>
        /// Access to common boolean-based extension behaviours.
        /// </summary>
        public static BooleanBlock Booleans { get; } = new();

        /// <summary>
        /// Access to common collection-based extension behaviours.
        /// </summary>
        public static CollectionsBlock Collections { get; } = new();

        /// <summary>
        /// Access to common date-based extension behaviours.
        /// </summary>
        public static DateBlock Dates { get; } = new();

        /// <summary>
        /// Access to common json-based extension behaviours.
        /// </summary>
        public static JsonBlock Json { get; } = new();

        /// <summary>
        /// Access to common numeric-based extension behaviours.
        /// </summary>
        public static NumbersBlock Numbers { get; } = new();

        /// <summary>
        /// Access to common object-based extension behaviours.
        /// </summary>
        public static ObjectBlock Objects { get; } = new();

        /// <summary>
        /// Access to common string-based extension behaviours.
        /// </summary>
        public StringBlock StringBlock { get; } = new();

        /// <summary>
        /// Access to common boolean-based extension behaviours.
        /// </summary>
        public BooleanBlock BooleanBlock { get; } = new();

        /// <summary>
        /// Access to common collection-based extension behaviours.
        /// </summary>
        public CollectionsBlock CollectionBlock { get; } = new();

        /// <summary>
        /// Access to common date-based extension behaviours.
        /// </summary>
        public DateBlock DateBlock { get; } = new();

        /// <summary>
        /// Access to common json-based extension behaviours.
        /// </summary>
        public JsonBlock JsonBlock { get; } = new();

        /// <summary>
        /// Access to common numeric-based extension behaviours.
        /// </summary>
        public NumbersBlock NumberBlock { get; } = new();

        /// <summary>
        /// Access to common object-based extension behaviours.
        /// </summary>
        public ObjectBlock ObjectBlock { get; } = new();
    }
}
