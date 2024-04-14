/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Openmoji
{
    public class OpenmojiDto
    {
        [JsonPropertyName("emoji")]
        public string Character { get; set; }

        [JsonPropertyName("hexcode")]
        public string HexCode { get; set; }

        [JsonPropertyName("group")]
        public string GroupName { get; set; }

        [JsonPropertyName("subgroups")]
        public string SubGroupNames { get; set; }

        [JsonPropertyName("annotation")]
        public string Annotation { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("openmoji_tags")]
        public string OpenmojiTags { get; set; }

        [JsonPropertyName("openmoji_author")]
        public string OpenmojiAuthor { get; set; }

        [JsonPropertyName("openmoji_date")]
        public string OpenmojiDate { get; set; }

        [JsonPropertyName("skintone")]
        public string SkinTone { get; set; }

        [JsonPropertyName("skintone_combination")]
        public string SkinToneCombination { get; set; }

        [JsonPropertyName("skintone_base_emoji")]
        public string SkinToneBaseCharacter { get; set; }

        [JsonPropertyName("skintone_base_hexcode")]
        public string SkinToneBaseHexCode { get; set; }

        [JsonPropertyName("unicode")]
        public decimal? Unicode { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }
}
