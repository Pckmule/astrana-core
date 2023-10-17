/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers.Enums;

namespace Astrana.Core.Domain.Models.Peers.Contracts
{
    public interface IPeerConnectionRequestReceived
    {
        Guid PeerConnectionRequestReceivedId { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Address { get; set; }

        string Note { get; set; }

        string PeerPreviewAccessToken { get; set; }

        PeerConnectionRequestStatus Status { get; set; }
    }
}