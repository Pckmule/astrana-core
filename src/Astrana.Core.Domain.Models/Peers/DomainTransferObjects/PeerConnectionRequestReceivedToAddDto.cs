/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Peers.DomainTransferObjects
{
    public sealed class PeerConnectionRequestReceivedToAddDto : IDomainTransferObject
    {
        public string? Address { get; set; }
        
        public string? Note { get; set; }

        public PeerSummaryDto? PeerSummary { get; set; }

        [ProtectedData]
        public string? PeerPreviewAccessToken { get; set; }
    }
}