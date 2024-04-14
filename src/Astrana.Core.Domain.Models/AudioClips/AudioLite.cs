/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.AudioClips.Contracts;

namespace Astrana.Core.Domain.Models.AudioClips
{
    public sealed class AudioLite : IAudio
    {
        public AudioLite(AudioClip fullModel)
        {
            AudioClipId = fullModel.AudioClipId;
            Location = fullModel.Location;
            Caption = fullModel.Caption;
            Copyright = fullModel.Copyright;
        }

        public Guid AudioClipId { get; set; }

        public string Location { get; set; }
        
        public string? Caption { get; set; }
        
        public string? Copyright { get; set; }
    }
}