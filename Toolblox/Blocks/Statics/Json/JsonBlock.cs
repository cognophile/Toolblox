using System;
using System.Text.Json;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Json;

namespace Cognophile.Toolblox.Blocks.Statics.Json
{
    public class JsonBlock : IBlock
    {
        /// <summary>
        /// Determine whether a given string contains valid JSON
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value indicating whether the given string is parsable JSON</returns>
        public static bool IsParsable(string subject)
        {
            return JsonBaseBlock.IsParsable(subject);
        }

        /// <summary>
        /// Serialize an object to JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <param name="pascalCase"></param>
        /// <returns></returns>
        public static string Serialize<T>(T subject, bool pascalCase = true)
        {
            return JsonBaseBlock.Serialize(subject, pascalCase);
        }

        /// <summary>
        /// Deserialize a JSON string to the given object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="caseInsensitive"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json, bool caseInsensitive = true) where T : new()
        {
            return JsonBaseBlock.Deserialize<T>(json, caseInsensitive);
        }

        /// <summary>
        /// Deserialize a JSON string to the given object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="caseInsensitive"></param>
        /// <returns></returns>
        public static T Deserialize<T>(JsonElement json, bool caseInsensitive = true) where T : new()
        {
            return JsonBaseBlock.Deserialize<T>(json, caseInsensitive);
        }
    }
}
