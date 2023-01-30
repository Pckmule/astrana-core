using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DM = Astrana.Core.Domain.Models.Languages;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        private readonly List<DM.Language> _settingsToSeed = new();

        public LanguageConfiguration()
        {
            _settingsToSeed.Add(new DM.Language
            {
                Name = Internationalization.DefaultLanguageName,
                NameTrxCode = Internationalization.DefaultLanguageNameTrxCode,
                TwoLetterCode = Internationalization.DefaultLanguageTwoLetterCode,
                ThreeLetterCode = Internationalization.DefaultLanguageThreeLetterCode,
                Direction = Internationalization.DefaultLanguageDirection
            });

            _settingsToSeed.Add(new DM.Language
            {
                Name = "French",
                NameTrxCode = "language_name_fr",
                TwoLetterCode = "fr",
                ThreeLetterCode = "fra",
                Direction = LanguageDirection.Ltr
            });

            _settingsToSeed.Add(new DM.Language
            {
                Name = "Chinese",
                NameTrxCode = "language_name_zh",
                TwoLetterCode = "zh",
                ThreeLetterCode = "zho",
                Direction = LanguageDirection.Ltr
            });

            _settingsToSeed.Add(new DM.Language
            {
                Name = "Hebrew",
                NameTrxCode = "language_name_he",
                TwoLetterCode = "he",
                ThreeLetterCode = "heb",
                Direction = LanguageDirection.Rtl
            });

            _settingsToSeed.Add(new DM.Language
            {
                Name = "Hindi",
                NameTrxCode = "language_name_hi",
                TwoLetterCode = "hi",
                ThreeLetterCode = "hin",
                Direction = LanguageDirection.Ltr
            });

            _settingsToSeed.Add(new DM.Language
            {
                Name = "Russian",
                NameTrxCode = "language_name_ru",
                TwoLetterCode = "ru",
                ThreeLetterCode = "rus",
                Direction = LanguageDirection.Ltr
            });

            _settingsToSeed.Add(new DM.Language
            {
                Name = "Spanish",
                NameTrxCode = "language_name_es",
                TwoLetterCode = "es",
                ThreeLetterCode = "esp",
                Direction = LanguageDirection.Ltr
            });
        }

        public void Configure(EntityTypeBuilder<Language> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();
            entityTypeBuilder.HasIndex(p => p.TwoLetterCode).IsUnique();
            entityTypeBuilder.HasIndex(p => p.ThreeLetterCode).IsUnique();

            entityTypeBuilder.HasData
            (
                GetLanguagesToSeed()
            );
        }

        private IEnumerable<Language> GetLanguagesToSeed()
        {
            var now = DateTime.UtcNow;
            var systemId = Guid.Parse(SystemUser.Id);

            var i = 1;
            return _settingsToSeed.Select(s => new Language
            {
                Id = Guid.NewGuid(),
                Name = s.Name,
                NameTrxCode = s.NameTrxCode,
                Direction = s.Direction,
                TwoLetterCode = s.TwoLetterCode,
                ThreeLetterCode = s.ThreeLetterCode,
                CreatedBy = systemId,
                CreatedTimestamp = now,
                LastModifiedBy = systemId,
                LastModifiedTimestamp = now

            }).ToArray();
        }
    }
}
