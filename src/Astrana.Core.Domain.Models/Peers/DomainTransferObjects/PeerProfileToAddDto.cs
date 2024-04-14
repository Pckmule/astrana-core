/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Peers.DomainTransferObjects
{
    public sealed class PeerProfileToAddDto : IDomainTransferObject
    {
        public string? FirstName { get; set; }

        public string? MiddleNames { get; set; }

        public string? LastName { get; set; }

        public DateTimeOffset? DateOfBirth { get; set; }

        public Sex? Sex { get; set; }

        public string? Introduction { get; set; }

        public ImageDto? ProfilePicture { get; set; }

        public ImageDto? CoverPicture { get; set; }
    }
}