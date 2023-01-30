﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Peers.Commands.AcceptPeerConnectionRequests
{
    public interface IAcceptPeerConnectionRequestsCommand
    {
        Task<UpdateResult<List<PeerConnectionRequestReceived>>> ExecuteAsync(IList<Guid> peerConnectionRequestIdsToAccept, Guid actioningUserId);
    }
}