/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Links.DomainTransferObjects
{
    public sealed class LinkToAddDto : IDomainTransferObject
    {
        public Uri? Url { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Caption { get; set; }

        public string? Locale { get; set; }

        public string? CharSet { get; set; }

        public string? Robots { get; set; }

        public string? SiteName { get; set; }

        public ImageDto? PreviewImage { get; set; }
    }
}