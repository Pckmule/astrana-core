/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.UserProfiles.Enums;

namespace Astrana.Core.Domain.Models.UserProfiles.Contracts
{
    public interface IUserProfile
    {
        Guid ProfileId { get; set; }

        Guid UserAccountId { get; set; }

        string FirstName { get; set; }

        string MiddleNames { get; set; }

        string LastName { get; set; }

        DateTimeOffset DateOfBirth { get; set; }

        Sex Sex { get; set; }

        string Introduction { get; set; }

        ContentCollection? ProfilePicturesCollection { get; set; }

        ContentCollection? CoverPicturesCollection { get; set; }
    }
}