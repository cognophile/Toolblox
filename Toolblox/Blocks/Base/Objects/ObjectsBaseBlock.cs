using System;
using System.Text.Json;

namespace Cognophile.Toolblox.Blocks.Base.Objects
{
    public static class ObjectsBaseBlock
    {
        public static bool IsNull(object subject)
        {
            return subject is null;
        }

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
