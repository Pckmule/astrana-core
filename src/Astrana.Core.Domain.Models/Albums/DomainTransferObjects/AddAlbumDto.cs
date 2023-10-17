/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Albums.DomainTransferObjects
{
    public sealed class AddAlbumDto : IDomainTransferObject
    {
        public string? Name { get; set; }
        
        public string? Caption { get; set; }

        public string? Copyright { get; set; }

        public List<AlbumItemDto>? Items { get; set; }
    }
}