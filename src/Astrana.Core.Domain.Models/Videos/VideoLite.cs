/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Videos.Contracts;

namespace Astrana.Core.Domain.Models.Videos
{
    public sealed class VideoLite : IVideo
    {
        public VideoLite(Video fullModel)
        {
            VideoId = fullModel.VideoId;
            Location = fullModel.Location;
            Caption = fullModel.Caption;
            Copyright = fullModel.Copyright;
        }

        public Guid VideoId { get; set; }

        public string Location { get; set; }
        
        public string? Caption { get; set; }
        
        public string? Copyright { get; set; }
    }
}