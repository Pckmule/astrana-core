/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Index = Microsoft.EntityFrameworkCore.IndexAttribute;
using DomainModelProperties = Astrana.Core.Domain.Models.Languages.Constants.ModelProperties;
using Astrana.Core.Enums;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Languages", Schema = SchemaNames.Configuration)]
    [Index(nameof(TwoLetterCode), IsUnique = true)]
    [Index(nameof(ThreeLetterCode), IsUnique = true)]
    public class Language : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.Language.MinimumNameLength)]
        [MaxLength(DomainModelProperties.Language.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Language.MinimumNameTrxCodeLength)]
        [MaxLength(DomainModelProperties.Language.MaximumNameTrxCodeLength)]
        [Column(Order = 2)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Language.MinimumCodeLength)]
        [MaxLength(DomainModelProperties.Language.MaximumCodeLength)]
        [Column(Order = 3)]
        public string Code { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Language.MinimumTwoLetterCodeLength)]
        [MaxLength(DomainModelProperties.Language.MaximumTwoLetterCodeLength)]
        [Column(Order = 4)]
        public string TwoLetterCode { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Language.MinimumThreeLetterCodeLength)]
        [MaxLength(DomainModelProperties.Language.MaximumThreeLetterCodeLength)]
        [Column(Order = 5)]
        public string ThreeLetterCode { get; set; }

        [Required]
        [Column(Order = 6)]
        public LanguageDirection Direction { get; set; }

        [Required]
        public List<Country> Countries { get; set; } = new();
    }
}
