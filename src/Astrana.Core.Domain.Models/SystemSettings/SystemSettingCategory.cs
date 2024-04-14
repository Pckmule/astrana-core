/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemSettings.Constants;
using Astrana.Core.Domain.Models.SystemSettings.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.SystemSettings
{
    public sealed class SystemSettingCategory : DomainEntity, ISystemSettingCategory
    {
        [JsonConstructor]
        public SystemSettingCategory() { }

        public SystemSettingCategory(string name, string nameTrxCode, string? description = null, string? descriptionTrxCode = null)
        {
            NameUnique = ModelProperties.SystemSettingCategory.NameUnique;
            NameSingularForm = ModelProperties.SystemSettingCategory.NameSingularForm;
            NamePluralForm = ModelProperties.SystemSettingCategory.NamePluralForm;

            Name = name;
            NameTrxCode = nameTrxCode;

            Description = description;
            DescriptionTrxCode = descriptionTrxCode;
        }

        [Required]
        [JsonIgnore]
        public Guid SystemSettingCategoryId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.SystemSettingCategory.MinimumNameLength)]
        [MaxLength(ModelProperties.SystemSettingCategory.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.SystemSettingCategory.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.SystemSettingCategory.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [MinLength(ModelProperties.SystemSettingCategory.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.SystemSettingCategory.MaximumDescriptionLength)]
        public string? Description { get; set; }

        [MinLength(ModelProperties.SystemSettingCategory.MinimumDescriptionTrxCodeLength)]
        [MaxLength(ModelProperties.SystemSettingCategory.MaximumDescriptionTrxCodeLength)]
        public string? DescriptionTrxCode { get; set; }

        [Required]
        public List<SystemSetting> Settings { get; set; } = new();

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}