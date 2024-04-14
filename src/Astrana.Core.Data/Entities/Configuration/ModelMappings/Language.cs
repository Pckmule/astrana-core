/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using LanguageDataEntity = Astrana.Core.Data.Entities.Configuration.Language;
using LanguageDomainEntity = Astrana.Core.Domain.Models.Languages.Language;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class Language
    {
        public static LanguageDomainEntity MapToDomainModel(LanguageDataEntity languageDataEntity)
        {
            var domainModel = new LanguageDomainEntity
            {
                LanguageId = languageDataEntity.LanguageId,

                Name = languageDataEntity.Name,
                NameTrxCode = languageDataEntity.NameTrxCode,

                TwoLetterCode = languageDataEntity.TwoLetterCode,
                ThreeLetterCode = languageDataEntity.ThreeLetterCode,

                Direction = languageDataEntity.Direction,

                DeactivatedReason = languageDataEntity.DeactivatedReason,
                DeactivatedBy = languageDataEntity.DeactivatedBy,
                DeactivatedTimestamp = languageDataEntity.DeactivatedTimestamp,

                CreatedBy = languageDataEntity.CreatedBy,
                CreatedTimestamp = languageDataEntity.CreatedTimestamp,

                LastModifiedBy = languageDataEntity.LastModifiedBy,
                LastModifiedTimestamp = languageDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
