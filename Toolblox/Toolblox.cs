using Cognophile.Toolblox.Blocks.Statics.Boolean;
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
        /// <summary>
        /// Access to common string-based extension behaviours.
        /// </summary>
        public static StringBlock Strings { get; } = new();

        /// <summary>
        /// Access to common boolean-based extension behaviours.
        /// </summary>
        public static BooleanBlock Booleans { get; } = new();
    }
}
