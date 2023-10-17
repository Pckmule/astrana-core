/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Audiences;

namespace Astrana.Core.Domain.Models.UserProfiles.Contracts
{
    public interface IUserProfileDetail
    {
        Guid UserProfileDetailId { get; set; }

        Guid UserProfileId { get; set; }

        string Key { get; set; }

        string IconName { get; set; }

        string Label { get; set; }

        string Value { get; set; }
        
        short DisplayOrder { get; set; }

        List<Audience> Audiences { get; set; }
    }
}
