/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Index = Microsoft.EntityFrameworkCore.IndexAttribute;
using DomainModelProperties = Astrana.Core.Domain.Models.Countries.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Countries", Schema = SchemaNames.Configuration)]
    [Index(nameof(TwoLetterCode), IsUnique = true)]
    [Index(nameof(ThreeLetterCode), IsUnique = true)]
    public class Country : BaseDeactivatableEntity<long, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.Country.MinimumNameLength)]
        [MaxLength(DomainModelProperties.Country.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Country.MinimumNameTrxCodeLength)]
        [MaxLength(DomainModelProperties.Country.MaximumNameTrxCodeLength)]
        [Column(Order = 2)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Country.MinimumTwoLetterCodeLength)]
        [MaxLength(DomainModelProperties.Country.MaximumTwoLetterCodeLength)]
        [Column(Order = 3)]
        public string TwoLetterCode { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Country.MinimumThreeLetterCodeLength)]
        [MaxLength(DomainModelProperties.Country.MaximumThreeLetterCodeLength)]
        [Column(Order = 4)]
        public string ThreeLetterCode { get; set; }
    }
}
