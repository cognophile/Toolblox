using System;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Toolblox.Blocks.Base.Json
{
    public static class JsonBaseBlock
    {
        /// <summary>
        /// Determine whether a given string contains valid JSON
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean value indicating whether the given string is parsable JSON</returns>
        public static bool IsParsable(string subject)
        {
            try
            {
                JObject obj = JObject.Parse(subject);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
            JsonSerializerOptions options = new();
            if (!pascalCase)
            {
                options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            }

            return JsonSerializer.Serialize(subject, subject.GetType(), options);
        }

        /// <summary>
        /// Deserialize a JSON string to the given object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="caseSensitive"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json, bool caseSensitive = true) where T : new()
        {
            try
            {
                JsonSerializerOptions options = new();
                if (!caseSensitive)
                {
                    options.PropertyNameCaseInsensitive = true;
                }

                return JsonSerializer.Deserialize<T>(json, options);
            }
            catch (JsonException)
            {
                return new T();
            }
        }

        /// <summary>
        /// Deserialize a JSON string to the given object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="caseSensitive"></param>
        /// <returns></returns>
        public static T Deserialize<T>(JsonElement json, bool caseSensitive = true) where T : new()
        {
            try
            {
                JsonSerializerOptions options = new();
                if (!caseSensitive)
                {
                    options.PropertyNameCaseInsensitive = true;
                }

                return JsonSerializer.Deserialize<T>(json.GetRawText(), options);
            }
            catch (JsonException)
            {
                return new T();
            }
        }
    }
}
