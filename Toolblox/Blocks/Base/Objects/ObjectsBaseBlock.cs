using System;
using System.Text.Json;

namespace Cognophile.Toolblox.Blocks.Base.Objects
{
    public static class ObjectsBaseBlock
    {
        /// <summary>
        /// Determines whether the object being called upon is null
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the null-state of the called-upon reference</returns>
        public static bool IsNull(object subject)
        {
            return subject is null;
        }

        /// <summary>
        /// Determines whether the object being called upon is not null
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the null-state of the called-upon reference</returns>
        public static bool IsNotNull(object subject)
        {
            return subject is not null;
        }

        /// <summary>
        /// Deep clone the called-upon object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <returns>Returns an instance of the specified type with identical property values</returns>
        public static T Clone<T>(T subject)
        {
            try
            {
                var serialized = JsonSerializer.Serialize(subject);
                return JsonSerializer.Deserialize<T>(serialized);
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
