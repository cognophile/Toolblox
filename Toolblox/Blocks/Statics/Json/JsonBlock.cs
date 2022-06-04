using System;
using System.Text.Json;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Json;

namespace Cognophile.Toolblox.Blocks.Statics.Json
{
    public sealed class JsonBlock : IBlock
    {
        /// <summary>
        /// Determine whether a given string contains valid JSON
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value indicating whether the given string is parsable JSON</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsParsable(string subject) => JsonBaseBlock.IsParsable(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Serialize an object to JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <param name="pascalCase"></param>
        /// <returns></returns>
#pragma warning disable CA1822 // Mark members as static
        public string Serialize<T>(T subject, bool pascalCase = true) => JsonBaseBlock.Serialize(subject, pascalCase);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Deserialize a JSON string to the given object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="caseInsensitive"></param>
        /// <returns></returns>
#pragma warning disable CA1822 // Mark members as static
        public T Deserialize<T>(string json, bool caseInsensitive = true) where T : new() => JsonBaseBlock.Deserialize<T>(json, caseInsensitive);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Deserialize a JSON string to the given object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="caseInsensitive"></param>
        /// <returns></returns>
#pragma warning disable CA1822 // Mark members as static
        public T Deserialize<T>(JsonElement json, bool caseInsensitive = true) where T : new() => JsonBaseBlock.Deserialize<T>(json, caseInsensitive);
#pragma warning restore CA1822 // Mark members as static
    }
}
