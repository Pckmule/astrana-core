/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Peers.DomainTransferObjects
{
    public sealed class PeerToAddDto : IDomainTransferObject
    {
        public Guid? ProfileId { get; set; }

        public string? Address { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public short? Age { get; set; }

        public Sex? Gender { get; set; }

        public string? Note { get; set; }

        public string? PeerAccessToken { get; set; }
    }
}