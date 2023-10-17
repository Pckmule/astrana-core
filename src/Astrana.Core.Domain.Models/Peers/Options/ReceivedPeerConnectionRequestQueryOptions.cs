/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Peers.Enums;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Peers.Options
{
    public class ReceivedPeerConnectionRequestQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IReceivedPeerConnectionRequestQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public ReceivedPeerConnectionRequestQueryOptions() { }

        public ReceivedPeerConnectionRequestQueryOptions(List<TRecordId> ids) : base(ids) { }

        public PeerConnectionRequestStatus? Status { get; set; }
    }
}
