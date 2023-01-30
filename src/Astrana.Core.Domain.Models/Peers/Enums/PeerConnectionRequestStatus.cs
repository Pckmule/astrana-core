/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.Peers.Enums
{
    [TranslationCode("peer_connection_request_status")]
    public enum PeerConnectionRequestStatus
    {
        [TranslationCode("default")]
        Default = 0,

        [TranslationCode("accepted")]
        Accepted = 1,

        [TranslationCode("rejected")]
        Rejected = 2
    }
}
