/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Reactions.Constants
{
    public static class DefaultReactions
    {
        public static readonly IReadOnlyCollection<Reaction> List = new List<Reaction>
        {
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Like",
                NameTrxCode = "reaction_name_like",
                IconName = "like",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Dislike",
                NameTrxCode = "reaction_name_dislike",
                IconName = "dislike",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Love",
                NameTrxCode = "reaction_name_love",
                IconName = "love",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Care",
                NameTrxCode = "reaction_name_care",
                IconName = "care",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Wow",
                NameTrxCode = "reaction_name_wow",
                IconName = "wow",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Haha",
                NameTrxCode = "reaction_name_laugh",
                IconName = "laugh",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Angry",
                NameTrxCode = "reaction_name_angry",
                IconName = "angry",
                UnicodeIcon = "1"
            },
            new()
            {
                ReactionId = Guid.NewGuid(),
                Name = "Sad",
                NameTrxCode = "reaction_name_sad",
                IconName = "sad",
                UnicodeIcon = "1"
            }
        };
    }
}
