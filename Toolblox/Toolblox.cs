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
    /// Access the suite of functionality provided by the library via this class
    ///   and its members.
    ///
    /// Alternative access to a select functionality set is also available via
    ///   the Extensions namespace of the library. 
    /// </summary>
    public static class Toolblox
    {
        /// <summary>
        /// Access to common string-based utilities and behaviours.
        /// </summary>
        public static StringBlock Strings { get; } = new();
    }
}
