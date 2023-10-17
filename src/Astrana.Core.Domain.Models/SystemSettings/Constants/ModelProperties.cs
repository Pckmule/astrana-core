/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.SystemSettings.Constants
{
    public static class ModelProperties
    {
        public static class SystemSetting
        {
            public static readonly string NameUnique = nameof(SystemSetting).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(SystemSetting).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(SystemSetting)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 200;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumDefaultValueLength = 0;
            public const int MaximumDefaultValueLength = 500;

            public const int MinimumValueLength = 1;
            public const int MaximumValueLength = 500;

            public const int MinimumShortDescriptionLength = 0;
            public const int MaximumShortDescriptionLength = 500;

            public const int MinimumShortDescriptionTrxCodeLength = 0;
            public const int MaximumShortDescriptionTrxCodeLength = 200;

            public const int MinimumHelpTextLength = 0;
            public const int MaximumHelpTextLength = 500;
        }

        public static class SystemSettingCategory
        {
            public static readonly string NameUnique = nameof(SystemSettingCategory).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(SystemSettingCategory).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(SystemSettingCategory).Replace("Category", "Categories")}".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 100;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 200;

            public const int MinimumDescriptionLength = 0;
            public const int MaximumDescriptionLength = 500;

            public const int MinimumDescriptionTrxCodeLength = 0;
            public const int MaximumDescriptionTrxCodeLength = 200;
        }
    }
}
