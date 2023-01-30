/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities.JsonConverters;
using System.Text.Json.Serialization;

namespace Astrana.Core.Attributes
{
    public sealed class JsonDateTimeFormatAttribute : JsonConverterAttribute
    {
        private readonly string _format;

        public JsonDateTimeFormatAttribute(string format)
        {
            _format = format;
        }

        public string Format => _format;

        public override JsonConverter CreateConverter(Type typeToConvert)
        {
            return new DateTimeFormatConverter(_format);
        }
    }
}
