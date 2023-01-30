/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ApiAccessTokens.Constants
{
    public static class ModelProperties
    {
        public static class ApiAccessToken
        {
            public static readonly string NameUnique = nameof(ApiAccessToken).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ApiAccessToken).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ApiAccessToken)}s".SplitOnUpperCase();
            
            public const int MinimumTokenLength = 1;
            public const int MaximumTokenLength = 1000;
        }
    }
}
