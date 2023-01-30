/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings.Constants;
using Astrana.Core.Domain.Models.SystemSettings.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.SystemSettings
{
    public sealed class SystemSetting : BaseDomainModel, ISystemSetting, IEditableEntity<Guid>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        [JsonConstructor]
        public SystemSetting() { }

        public SystemSetting(string name, SystemDataType dataType, string defaultValue, string value, string? shortDescription = null, string? helpText = null)
        {
            NameUnique = ModelProperties.SystemSetting.NameUnique;
            NameSingularForm = ModelProperties.SystemSetting.NameSingularForm;
            NamePluralForm = ModelProperties.SystemSetting.NamePluralForm;

            Name = name;
            DataType = dataType;

            DefaultValue = defaultValue;
            Value = value;

            ShortDescription = shortDescription;
            HelpText = helpText;


        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(ModelProperties.SystemSetting.MinimumNameLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumNameLength)]
        public string Name { get; set; }

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

        [MinLength(ModelProperties.SystemSetting.MinimumShortDescriptionLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumShortDescriptionLength)]
        public string? ShortDescription { get; set; }

        [MinLength(ModelProperties.SystemSetting.MinimumHelpTextLength)]
        [MaxLength(ModelProperties.SystemSetting.MaximumHelpTextLength)]
        public string? HelpText { get; set; }

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

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}