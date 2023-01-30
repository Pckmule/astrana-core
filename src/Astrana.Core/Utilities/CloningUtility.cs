using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Utilities
{
    public static class CloningUtility
    {
        public static TCloneType Clone<TCloneType>(this TCloneType source)
        {
            if (ReferenceEquals(source, null))
                return default;

            var deserializeSettings = new JsonSerializerOptions();
            var serializeSettings = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles };

            return JsonSerializer.Deserialize<TCloneType>(JsonSerializer.Serialize(source, serializeSettings), deserializeSettings) ?? default;
        }
    }
}
