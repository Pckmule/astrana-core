/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Albums.Constants
{
    public static class ModelProperties
    {
        public static class Album
        {
            public static readonly string NameUnique = nameof(Album).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Album).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Album)}s".SplitOnUpperCase();
        }

        public static class AlbumItem
        {
            public static readonly string NameUnique = nameof(AlbumItem).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(AlbumItem).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(AlbumItem)}s".SplitOnUpperCase();
        }
    }
}
