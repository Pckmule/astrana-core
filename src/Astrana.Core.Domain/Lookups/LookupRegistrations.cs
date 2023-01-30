/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSetup.Enums;
using Astrana.Core.Domain.Models.Tags.Enums;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Enums;

namespace Astrana.Core.Domain.Lookups
{
    public static class LookupRegistrations
    {
        public static List<Type> Get()
        {
            var enums = new List<Type>
            {
                typeof(SystemSetupStatus),
                typeof(DatabaseProvider),
                typeof(ContentFormat),
                typeof(SortDirection),
                typeof(Gender),
                typeof(NameCombination),
                typeof(UserAccountType),
                typeof(TagFilterMode)
            };

            return enums;
        }
    }
}
