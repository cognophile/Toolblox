﻿using System;
using System.Text.Json;
using Cognophile.Toolblox.Blocks.Base.Json;

namespace Cognophile.Toolblox.Blocks.Extensions.Json
{
    public static class JsonExtensionBlock
    {
        /// <summary>
        /// Determine whether a given string contains valid JSON
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value indicating whether the given string is parsable JSON</returns>
        public static bool IsParsable(this string subject)
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
        public static string Serialize<T>(this T subject, bool pascalCase = true)
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
        public static T Deserialize<T>(this string json, bool caseInsensitive = true) where T : new()
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
        public static T Deserialize<T>(this JsonElement json, bool caseInsensitive = true) where T : new()
        {
            return JsonBaseBlock.Deserialize<T>(json, caseInsensitive);
        }
    }
}
