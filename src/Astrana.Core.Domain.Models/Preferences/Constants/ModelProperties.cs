/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Preferences.Constants
{
    public static class ModelProperties
    {
        public static class UserPreferences
        {
            public static readonly string NameUnique = nameof(UserPreferences).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(UserPreferences).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(UserPreferences)}s".SplitOnUpperCase();
        }
    }
}
