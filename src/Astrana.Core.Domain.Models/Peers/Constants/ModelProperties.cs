/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Peers.Constants
{
    public static class ModelProperties
    {
        public static class Peer
        {
            public static readonly string NameUnique = nameof(Peer).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Peer).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Peer)}s".SplitOnUpperCase();

            public const int MinimumFirstNameLength = 1;
            public const int MaximumFirstNameLength = 100;

            public const int MinimumLastNameLength = 1;
            public const int MaximumLastNameLength = 100;

            public const int MinimumAddressLength = 1;
            public const int MaximumAddressLength = 500;

            public const int MinimumNoteLength = 0;
            public const int MaximumNoteLength = 500;

            public const int MinimumPeerAccessTokenLength = 0;
            public const int MaximumPeerAccessTokenLength = 2000;
        }

        public static class PeerProfile
        {
            public static readonly string NameUnique = nameof(PeerProfile).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PeerProfile).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PeerProfile)}s".SplitOnUpperCase();

            public const int MinimumFirstNameLength = ApplicationUser.MinimumFirstNameLength;
            public const int MaximumFirstNameLength = ApplicationUser.MaximumFirstNameLength;

            public const int MinimumMiddleNamesLength = ApplicationUser.MinimumMiddleNamesLength;
            public const int MaximumMiddleNamesLength = ApplicationUser.MaximumMiddleNamesLength;

            public const int MinimumLastNameLength = ApplicationUser.MinimumLastNameLength;
            public const int MaximumLastNameLength = ApplicationUser.MaximumLastNameLength;

            public const int MinimumIntroductionLength = 0;
            public const int MaximumIntroductionLength = 100;
        }

        public static class PeerCircle
        {
            public static readonly string NameUnique = nameof(PeerCircle).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PeerCircle).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PeerCircle)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 100;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumDescriptionLength = 1;
            public const int MaximumDescriptionLength = 100;

            public const int MinimumDescriptionTrxCodeLength = 1;
            public const int MaximumDescriptionTrxCodeLength = 100;
        }

        public static class PeerConnectionRequestReceived
        {
            public static readonly string NameUnique = nameof(PeerConnectionRequestReceived).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PeerConnectionRequestReceived).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PeerConnectionRequestReceived)}s".SplitOnUpperCase();

            public const int MinimumFirstNameLength = 1;
            public const int MaximumFirstNameLength = 100;

            public const int MinimumLastNameLength = 1;
            public const int MaximumLastNameLength = 100;

            public const int MinimumAddressLength = 1;
            public const int MaximumAddressLength = 500;

            public const int MinimumNoteLength = 0;
            public const int MaximumNoteLength = 500;

            public const int MinimumPeerPreviewAccessTokenLength = 0;
            public const int MaximumPeerPreviewAccessTokenLength = 2000;
        }

        public static class PeerConnectionRequestSubmitted
        {
            public static readonly string NameUnique = nameof(PeerConnectionRequestSubmitted).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PeerConnectionRequestSubmitted).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PeerConnectionRequestSubmitted)}s".SplitOnUpperCase();

            public const int MinimumFirstNameLength = 1;
            public const int MaximumFirstNameLength = 100;

            public const int MinimumLastNameLength = 1;
            public const int MaximumLastNameLength = 100;

            public const int MinimumAddressLength = 1;
            public const int MaximumAddressLength = 500;

            public const int MinimumNoteLength = 0;
            public const int MaximumNoteLength = 500;

            public const int MinimumPeerPreviewAccessTokenLength = 0;
            public const int MaximumPeerPreviewAccessTokenLength = 2000;
        }
    }
}
