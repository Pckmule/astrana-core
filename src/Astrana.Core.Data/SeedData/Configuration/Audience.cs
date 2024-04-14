/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Astrana.Core.Data.SeedData.Configuration
{
    public static class AudienceSeedData
    {
        public static IReadOnlyList<Audience> Audiences => new List<Audience>
        {
            new()
            {
                AudienceId = Guid.Parse("94b9b87c-a0a1-4721-a905-897b12e81fc7"),
                Name = "Only Me",
                NameTrxCode = "only_me",
                Description = "Content associated with this audience will only be accessible to it's owner.",
                DescriptionTrxCode = "audience_description_me",
                IsUserDefined = false,
                CreatedBy = SystemUser.IdGuid, 
                CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), 
                LastModifiedBy = SystemUser.IdGuid, 
                LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan())
            },

            new()
            {
                AudienceId = Guid.Parse("0b255ccf-19e4-49c0-a3e0-d8513416d52d"),
                Name = "Family",
                NameTrxCode = "family",
                Description = "Content associated with this audience will only be accessible to peers that are considered family.",
                DescriptionTrxCode = "audience_description_family",
                IsUserDefined = false,
                CreatedBy = SystemUser.IdGuid,
                CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()),
                LastModifiedBy = SystemUser.IdGuid,
                LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan())
            },

            new()
            {
                AudienceId = Guid.Parse("7255b812-56c0-4293-ba3e-f3a28e7256e3"),
                Name = "Professional",
                NameTrxCode = "professional",
                Description = "Content associated with this audience will only be accessible to peers that are considered part of your professional network.",
                DescriptionTrxCode = "audience_description_professional",
                IsUserDefined = false,
                CreatedBy = SystemUser.IdGuid,
                CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()),
                LastModifiedBy = SystemUser.IdGuid,
                LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan())
            },

            new()
            {
                AudienceId = Guid.Parse("0c4e6f37-09af-4b5b-9081-42368f9884ea"),
                Name = "Public",
                NameTrxCode = "public",
                Description = "Content associated with this audience will be accessible to everyone.",
                DescriptionTrxCode = "audience_description_public",
                IsUserDefined = false,
                CreatedBy = SystemUser.IdGuid,
                CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()),
                LastModifiedBy = SystemUser.IdGuid,
                LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan())
            }
        };

        public static Audience? FindById(Guid entityId)
        {
            return Audiences.FirstOrDefault(o => o.AudienceId == entityId);
        }

        public static void AddAudienceData(this ModelBuilder model)
        {
            model.Entity<Audience>().HasData(Audiences);
        }
    }
}
