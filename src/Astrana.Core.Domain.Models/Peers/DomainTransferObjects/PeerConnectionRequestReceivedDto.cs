/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.Peers.Enums;
using Astrana.Core.Framework.Model;
using Microsoft.AspNetCore.Identity;

namespace Astrana.Core.Domain.Models.Peers.DomainTransferObjects
{
    public sealed class PeerConnectionRequestReceivedDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }
        
        public string? Address { get; set; }

        public PeerSummaryDto? PeerSummary { get; set; }

        public string? Note { get; set; }

        [ProtectedData]
        public string? PeerPreviewAccessToken { get; set; }

        public PeerConnectionRequestStatus? Status { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }
    }
}