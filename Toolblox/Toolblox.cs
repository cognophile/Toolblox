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
        /// Access to common string-based utilities and behaviours.
        /// </summary>
        public static StringBlock Strings { get; } = new();

        //public static NumberBlock Numbers { get; } = new();

        //public static CollectionBlock Collections { get; } = new();

        //public static ObjectBlock Objects { get; } = new();

        //public static DateBlock Dates { get; } = new();

        //public static JsonBlock Json { get; } = new();

        //public static ValidationBlock Validation { get; } = new();

        //public static TestBlock Tests { get; } = new();

        //public static MvcBlock Mvc { get; } = new();

        //public static GuardBlock Guard { get; } = new();
    }
}
