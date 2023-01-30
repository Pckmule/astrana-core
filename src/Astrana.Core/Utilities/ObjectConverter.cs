using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Utilities
{
    public static class ObjectConverter
    {
        public static async Task<TConvertTo> ConvertAsync<TConvertTo>(dynamic sourceModel)
            where TConvertTo: class
        {
            if (sourceModel == null)
                return null!;

            var serializeSettings = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles };
            var deserializeSettings = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };

            return await JsonSerializer.DeserializeAsync<TConvertTo>(JsonSerializer.Serialize(sourceModel, serializeSettings), deserializeSettings);
        }
    }
}
