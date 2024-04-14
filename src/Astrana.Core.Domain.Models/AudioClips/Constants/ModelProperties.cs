/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.AudioClips.Constants
{
    public static class ModelProperties
    {
        public static class AudioClip
        {
            public static readonly string NameUnique = nameof(AudioClip).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(AudioClip).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(AudioClip)}s".SplitOnUpperCase();
            
            public const int MinimumLocationLength = 1;
            public const int MaximumLocationLength = 2500;

            public const int MinimumCaptionLength = 0;
            public const int MaximumCaptionLength = 100;

            public const int MinimumCopyrightLength = 0;
            public const int MaximumCopyrightLength = 500;
        }
    }
}
