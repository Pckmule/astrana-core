/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Notifications.Constants
{
    public static class ModelProperties
    {
        public static class Notification
        {
            public static readonly string NameUnique = nameof(Notification).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Notification).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Notification)}s".SplitOnUpperCase();

            public const int MinimumMessageLength = 1;
            public const int MaximumMessageLength = 500;

            public const int MinimumSourceIdLength = 1;
            public const int MaximumSourceIdLength = 36;

        }
    }
}
