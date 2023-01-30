/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Peers.Contracts
{
    public interface IPeer
    {
        Guid Id { get; set; }

        string FirstName { get; set; }

        string? LastName { get; set; }

        string Address { get; set; }

        string Note { get; set; }

        string PeerAccessToken { get; set; }

        bool IsMuted { get; set; }
    }
}