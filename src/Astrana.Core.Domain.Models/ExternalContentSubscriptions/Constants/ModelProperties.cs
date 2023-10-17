﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ExternalContentSubscriptions.Constants
{
    public static class ModelProperties
    {
        public static class ExternalContentSubscription
        {
            public static readonly string NameUnique = nameof(ExternalContentSubscription).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ExternalContentSubscription).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ExternalContentSubscription)}s".SplitOnUpperCase();

            public const int IdMinLength = 1;
            public const int IdMaxLength = int.MaxValue;

            public const int MinimumUrlLength = 1;
            public const int MaximumUrlLength = 500;

            public const int MinimumTitleLength = 1;
            public const int MaximumTitleLength = 250;

            public const int MinimumDescriptionLength = 1;
            public const int MaximumDescriptionLength = 500;
        }
    }
}
