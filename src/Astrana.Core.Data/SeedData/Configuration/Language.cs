/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Language = Astrana.Core.Data.Entities.Configuration.Language;


namespace Astrana.Core.Data.SeedData.Configuration
{
    public static class LanguageSeedData
    {
        public static IReadOnlyList<Language> Languages => new List<Language>
        {
            new() { LanguageId = Guid.Parse("ccb2efb1-74b4-4aca-b110-a3ba153e4b92"), Name = "Afrikaans", NameTrxCode = "language_name_af", TwoLetterCode = "af", ThreeLetterCode =  "afr", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("e2bd6da4-2d43-49ff-ae10-c61ebcf305b6"), Name = "Chinese", NameTrxCode = "language_name_zh", TwoLetterCode = "zh", ThreeLetterCode =  "zho", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("4bd4c1a1-9736-4f04-b974-90bc1cd61630"), Name = "English", NameTrxCode = "language_name_en", TwoLetterCode = "en", ThreeLetterCode =  "eng", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("804b9015-ca16-4fb0-8cc6-20e362fb3afb"), Name = "French", NameTrxCode = "language_name_fr", TwoLetterCode = "fr", ThreeLetterCode =  "fra", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("2dde1e98-256b-4816-a58a-d9430982f525"), Name = "German", NameTrxCode = "language_name_de", TwoLetterCode = "de", ThreeLetterCode =  "deu", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("c09905d9-10e4-4e61-bf83-d037533e377e"), Name = "Hebrew", NameTrxCode = "language_name_he", TwoLetterCode = "he", ThreeLetterCode =  "heb", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("65cff48a-6729-4d4f-a974-7bc27204b09a"), Name = "Hindi", NameTrxCode = "language_name_hi", TwoLetterCode = "hi", ThreeLetterCode =  "hin", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("1c9985ff-2c5f-4574-a126-fd04d583c0d2"), Name = "Italian", NameTrxCode = "language_name_it", TwoLetterCode = "it", ThreeLetterCode =  "ita", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("0b79c147-cc62-4071-ada8-cb2e5d06ad72"), Name = "Japanese", NameTrxCode = "language_name_ja", TwoLetterCode = "ja", ThreeLetterCode =  "jpn", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("b0b595b9-5133-4d31-8218-901b6426ec0f"), Name = "Russian", NameTrxCode = "language_name_ru", TwoLetterCode = "ru", ThreeLetterCode =  "rus", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("884a154f-eb78-4a7a-bddc-e58ae631b884"), Name = "Xhosa", NameTrxCode = "language_name_xh", TwoLetterCode = "xh", ThreeLetterCode =  "xho", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) },
            new() { LanguageId = Guid.Parse("54880bec-0fdd-4ad6-af13-9042d0916615"), Name = "Zulu", NameTrxCode = "language_name_zu", TwoLetterCode = "zu", ThreeLetterCode =  "zul", Direction = LanguageDirection.Ltr, CreatedBy = SystemUser.IdGuid, CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()), LastModifiedBy = SystemUser.IdGuid, LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()) }
        };

        public static Language? FindById(Guid entityId)
        {
            return Languages.FirstOrDefault(o => o.LanguageId == entityId);
        }

        public static void AddLanguageData(this ModelBuilder model)
        {
            model.Entity<Language>().HasData(Languages);
        }
    }
}
