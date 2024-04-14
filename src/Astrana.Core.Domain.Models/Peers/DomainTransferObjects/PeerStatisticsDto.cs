/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Peers.DomainTransferObjects
{
    public sealed class PeerStatisticsDto : IDomainTransferObject
    {
        public int? PeerCount { get; set; }

        public int? MutualPeerCount { get; set; }

        public DateTimeOffset? ConnectionDate { get; set; }
    }
}