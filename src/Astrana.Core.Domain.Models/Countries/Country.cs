/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries.Constants;
using Astrana.Core.Domain.Models.Countries.Contracts;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Countries
{
    public class Country : BaseDomainModel, ICountry, IEditableEntity<long>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _twoLetterCode;
        private string _threeLetterCode;

        public Country()
        {
            NameUnique = ModelProperties.Country.NameUnique;
            NameSingularForm = ModelProperties.Country.NameSingularForm;
            NamePluralForm = ModelProperties.Country.NamePluralForm;
        }

        public long Id { get; set; }

        [Required]
        [MinLength(ModelProperties.Country.MinimumNameLength)]
        [MaxLength(ModelProperties.Country.MaximumNameLength)]
        public string Name { get; set; }

        [MinLength(ModelProperties.Country.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Country.MinimumTwoLetterCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumTwoLetterCodeLength)]
        public string TwoLetterCode
        {
            get => _twoLetterCode;
            set => _twoLetterCode = value.ToUpperInvariant();
        }

        [MinLength(ModelProperties.Country.MinimumThreeLetterCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumThreeLetterCodeLength)]
        public string ThreeLetterCode
        {
            get => _threeLetterCode;
            set => _threeLetterCode = value.ToUpperInvariant();
        }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}