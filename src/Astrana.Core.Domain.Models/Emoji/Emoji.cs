/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Emoji
{
    // DTO?
    public class Emoji : IDomainTransferObject
    {
        public string Character { get; set; }
        
        public string? HexCode { get; set; }
        
        public string? GroupName { get; set; }
        
        public List<string>? SubGroupNames { get; set; }
        
        public string? Annotation { get; set; }
        
        public List<string>? Tags { get; set; }
        
        public string? SkinTone { get; set; }

        public string? SkinToneCombination { get; set; }

        public string? SkinToneBaseCharacter { get; set; }

        public string? SkinToneBaseHexCode { get; set; }

        public decimal? Unicode { get; set; }

        public int? Order { get; set; }

        public List<Emoji>? Variants { get; set; }
    }
}
