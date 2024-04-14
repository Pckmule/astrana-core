/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Locations.Constants
{
    public static class ModelProperties
    {
        public static class Location
        {
            public static readonly string NameUnique = nameof(Location).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Location).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Location)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 250;
        }
    }
}
