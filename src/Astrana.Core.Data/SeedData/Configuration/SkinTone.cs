/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Microsoft.EntityFrameworkCore;
using SkinTone = Astrana.Core.Data.Entities.Configuration.SkinTone;


namespace Astrana.Core.Data.SeedData.Configuration
{
    public static class SkinToneSeedData
    {
        public static IReadOnlyList<SkinTone> SkinTones => new List<SkinTone>
        {
            new() { SkinToneId = Guid.Parse("86146d02-a42a-4804-8d6b-1cdb90baafd7"), Name = "Default", NameTrxCode = "skintone_name_default", Description = "", DescriptionTrxCode =  "skintone_description_default", ColorCode = "#FCEA2B", CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { SkinToneId = Guid.Parse("2469a010-313c-4c7f-991d-2fab9bf2245f"), Name = "Light", NameTrxCode = "skintone_name_light", Description = "", DescriptionTrxCode =  "skintone_description_light", ColorCode = "#FADCDC", CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { SkinToneId = Guid.Parse("59bc3be7-4bb1-4c9d-801d-de233002e6e7"), Name = "MediumLight", NameTrxCode = "skintone_name_mediumlight", Description = "", DescriptionTrxCode =  "skintone_description_mediumlight", ColorCode = "#DEBB90", CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { SkinToneId = Guid.Parse("a11a3f21-e8fa-49d3-b516-ec5b95f2fa70"), Name = "Medium", NameTrxCode = "skintone_name_medium", Description = "", DescriptionTrxCode =  "skintone_description_medium", ColorCode = "#C19A65", CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { SkinToneId = Guid.Parse("4b61cbb8-8c4a-4893-a73c-47fc8e0361e3"), Name = "MediumDark", NameTrxCode = "skintone_name_mediumdark", Description = "", DescriptionTrxCode =  "skintone_description_mediumdark", ColorCode = "#A57939", CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { SkinToneId = Guid.Parse("13cf913a-613e-403d-a55c-5bf30a1205af"), Name = "Dark", NameTrxCode = "skintone_name_dark", Description = "", DescriptionTrxCode =  "skintone_description_dark", ColorCode = "#6A462F", CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) }
        };

        public static SkinTone? FindById(Guid entityId)
        {
            return SkinTones.FirstOrDefault(o => o.SkinToneId == entityId);
        }

        public static void AddSkinToneData(this ModelBuilder model)
        {
            model.Entity<SkinTone>().HasData(SkinTones);
        }
    }
}
