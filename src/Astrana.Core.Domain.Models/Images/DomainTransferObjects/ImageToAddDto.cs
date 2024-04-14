/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Images.DomainTransferObjects
{
    public sealed class ImageToAddDto : IDomainTransferObject
    {
        public string? Location { get; set; }
        
        public string? Caption { get; set; }

        public string? Copyright { get; set; }

        public FileSizeInfoDto? Size { get; set; }
    }
}