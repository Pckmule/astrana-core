/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Utilities.JsonConverters
{
    public class DateTimeFormatConverter : JsonConverter<DateTimeOffset>
    {
        private readonly string _format;

        public DateTimeFormatConverter(string format)
        {
            _format = format;
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString(), CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            ArgumentNullException.ThrowIfNull(writer, nameof(writer));

            writer.WriteStringValue(value.ToString(_format, CultureInfo.InvariantCulture));
        }
    }
}