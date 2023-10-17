﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Albums.DomainTransferObjects
{
    public sealed class AlbumDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public string? Name { get; set; }
        
        public string? Caption { get; set; }

        public string? Copyright { get; set; }

        public List<AlbumItemDto>? Items { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }
    }
}