/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images.Contracts;

namespace Astrana.Core.Domain.Models.Images
{
    public sealed class ImageLite : IImage
    {
        public ImageLite(Image fullModel)
        {
            Id = fullModel.Id;
            Location = fullModel.Location;
            Caption = fullModel.Caption;
            Copyright = fullModel.Copyright;
        }

        public Guid Id { get; set; }

        public string Location { get; set; }
        
        public string? Caption { get; set; }
        
        public string? Copyright { get; set; }
    }
}