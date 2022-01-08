using System;
using System.Text.Json;

namespace Toolblox.Blocks.Base.Objects
{
    public static class ObjectsBlock
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
