/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.SkinTones.DomainTransferObjects
{
    public sealed class SkinToneDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public string? Name { get; set; }
        
        public string? NameTrxCode { get; set; }
        
        public string? ColorCode { get; set; }

        public string? Description { get; set; }

        public string? DescriptionTrxCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }
    }
}