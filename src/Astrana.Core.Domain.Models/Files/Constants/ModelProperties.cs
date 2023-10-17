/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Files.Constants
{
    public static class ModelProperties
    {
        public static class File
        {
            public static readonly string NameUnique = nameof(File).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(File).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(File)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 200;

            public const int MinimumTypeLength = 1;
            public const int MaximumTypeLength = 10;

            public const int MinimumUrlLength = 1;
            public const int MaximumUrlLength = 1000;
        }

        public static class ProcessedFile
        {
            public static readonly string NameUnique = nameof(ProcessedFile).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ProcessedFile).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ProcessedFile)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 200;

            public const int MinimumTypeLength = 1;
            public const int MaximumTypeLength = 10;

            public const int MinimumUrlLength = 1;
            public const int MaximumUrlLength = 1000;
        }

        public static class UploadedFile
        {
            public static readonly string NameUnique = nameof(UploadedFile).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(UploadedFile).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(UploadedFile)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 200;

            public const int MinimumTypeLength = 1;
            public const int MaximumTypeLength = 10;

            public const int MinimumUrlLength = 1;
            public const int MaximumUrlLength = 1000;
        }
    }
}
