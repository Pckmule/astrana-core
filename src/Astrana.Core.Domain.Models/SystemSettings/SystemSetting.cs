/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings.Constants;
using Astrana.Core.Domain.Models.SystemSettings.Contracts;
using Astrana.Core.Domain.Models.SystemSettings.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.SystemSettings
{
    public sealed class SystemSetting : DomainEntity, ISystemSetting, IAuditable<Guid>
    {
        [JsonConstructor]
        public SystemSetting() { }

        public SystemSetting(string name, SystemDataType dataType, string defaultValue, string value, string? shortDescription = null, string? shortDescriptionTrxCode = null, string? helpText = null, string? helpTextTrxCode = null, Guid? systemSettingCategoryId = null, bool? userMaySet = null)
        {
            NameUnique = ModelProperties.SystemSetting.NameUnique;
            NameSingularForm = ModelProperties.SystemSetting.NameSingularForm;
            NamePluralForm = ModelProperties.SystemSetting.NamePluralForm;

            Name = name;
            DataType = dataType;

            DefaultValue = defaultValue;
            Value = value;

            ShortDescription = shortDescription;
            ShortDescriptionTrxCode = shortDescriptionTrxCode;

            HelpText = helpText;
            HelpTextTrxCode = helpTextTrxCode;
            
            SystemSettingCategoryId = systemSettingCategoryId;

            UserMaySet = userMaySet ?? false;
        }

        public SystemSetting(SystemSettingDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                SystemSettingId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (dto.DataType.HasValue)
                DataType = dto.DataType.Value;

            if (!string.IsNullOrEmpty(dto.ShortDescription))
                ShortDescription = dto.ShortDescription;

            if (!string.IsNullOrEmpty(dto.ShortDescriptionTrxCode))
                ShortDescriptionTrxCode = dto.ShortDescriptionTrxCode;

            if (!string.IsNullOrEmpty(dto.DefaultValue))
                DefaultValue = dto.DefaultValue;

            if (!string.IsNullOrEmpty(dto.Value))
                Value = dto.Value;

            if (!string.IsNullOrEmpty(dto.HelpText))
                HelpText = dto.HelpText;

            if (!string.IsNullOrEmpty(dto.HelpTextTrxCode))
                HelpTextTrxCode = dto.HelpTextTrxCode;

            if (dto.MinimumValueLength.HasValue)
                MinimumValueLength = dto.MinimumValueLength.Value;

            if (dto.MaximumValueLength.HasValue)
                MaximumValueLength = dto.MaximumValueLength.Value;

            if (dto.MinimumValues.HasValue)
                MinimumValues = dto.MinimumValues.Value;

            if (dto.MaximumValues.HasValue)
                MaximumValues = dto.MaximumValues.Value;

            if (dto.SystemSettingCategoryId.HasValue)
                SystemSettingCategoryId = dto.SystemSettingCategoryId.Value;

            if (dto.UserMaySet.HasValue)
                UserMaySet = dto.UserMaySet.Value;

            if (dto.CreatedBy.HasValue)
                CreatedBy = dto.CreatedBy.Value;

            if (dto.CreatedTimestamp.HasValue)
                CreatedTimestamp = dto.CreatedTimestamp.Value;

            if (dto.LastModifiedBy.HasValue)
                LastModifiedBy = dto.LastModifiedBy.Value;

            if (dto.LastModifiedTimestamp.HasValue)
                LastModifiedTimestamp = dto.LastModifiedTimestamp.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        public SystemSetting(SystemSettingToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            SystemSettingId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (dto.DataType.HasValue)
                DataType = dto.DataType.Value;

            if (!string.IsNullOrEmpty(dto.ShortDescription))
                ShortDescription = dto.ShortDescription;

            if (!string.IsNullOrEmpty(dto.ShortDescriptionTrxCode))
                ShortDescriptionTrxCode = dto.ShortDescriptionTrxCode;

            if (!string.IsNullOrEmpty(dto.DefaultValue))
                DefaultValue = dto.DefaultValue;

            if (!string.IsNullOrEmpty(dto.Value))
                Value = dto.Value;

            if (!string.IsNullOrEmpty(dto.HelpText))
                HelpText = dto.HelpText;

            if (!string.IsNullOrEmpty(dto.HelpTextTrxCode))
                HelpTextTrxCode = dto.HelpTextTrxCode;

            if (dto.MinimumValueLength.HasValue)
                MinimumValueLength = dto.MinimumValueLength.Value;

            if (dto.MaximumValueLength.HasValue)
                MaximumValueLength = dto.MaximumValueLength.Value;

            if (dto.MinimumValues.HasValue)
                MinimumValues = dto.MinimumValues.Value;

            if (dto.MaximumValues.HasValue)
                MaximumValues = dto.MaximumValues.Value;

            if (dto.SystemSettingCategoryId.HasValue)
                SystemSettingCategoryId = dto.SystemSettingCategoryId.Value;

            if (dto.UserMaySet.HasValue)
                UserMaySet = dto.UserMaySet.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid SystemSettingId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.SystemSetting.MinimumNameLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.SystemSetting.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [Required]
        public SystemDataType DataType { get; set; }

        [Required]
        [MinLength(ModelProperties.SystemSetting.MinimumDefaultValueLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumDefaultValueLength)]
        public string DefaultValue { get; set; }

        [Required]
        [MinLength(ModelProperties.SystemSetting.MinimumValueLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumValueLength)]
        public string? Value { get; set; }

        [JsonIgnore]
        public string ValueOrDefault => Value ?? DefaultValue;
        
        [MinLength(ModelProperties.SystemSetting.MinimumValueOptionsLookupNameLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumValueOptionsLookupNameLength)]
        public string? ValueChoicesLookupName { get; set; }
        
        public int? MaximumValues { get; set; }
        
        public int? MinimumValues { get; set; }
        
        public int? MaximumValueLength { get; set; }
        
        public int? MinimumValueLength { get; set; }

        [MinLength(ModelProperties.SystemSetting.MinimumShortDescriptionLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumShortDescriptionLength)]
        public string? ShortDescription { get; set; }

        [MinLength(ModelProperties.SystemSetting.MinimumShortDescriptionTrxCodeLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumShortDescriptionTrxCodeLength)]
        public string? ShortDescriptionTrxCode { get; set; }

        [MinLength(ModelProperties.SystemSetting.MinimumHelpTextLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumHelpTextLength)]
        public string? HelpText { get; set; }

        [MinLength(ModelProperties.SystemSetting.MinimumHelpTextTrxCodeLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumHelpTextTrxCodeLength)]
        public string? HelpTextTrxCode { get; set; }

        public Guid? SystemSettingCategoryId { get; set; }

        [Required]
        public bool UserMaySet { get; set; }
        
        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override SystemSettingDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            var dto = new SystemSettingDto
            {
                Name = Name,
                NameTrxCode = NameTrxCode,

                DataType = DataType,

                DefaultValue = DefaultValue,
                Value = Value,

                ShortDescription = ShortDescription,
                ShortDescriptionTrxCode = ShortDescriptionTrxCode,

                HelpText = HelpText,

                UserMaySet = UserMaySet
            };

            if (includeId)
                dto.Id = Id;

            if (includeAuditData)
            {
                dto.CreatedBy = CreatedBy;
                dto.CreatedTimestamp = CreatedTimestamp;
                dto.LastModifiedBy = LastModifiedBy;
                dto.LastModifiedTimestamp = LastModifiedTimestamp;
            }

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}