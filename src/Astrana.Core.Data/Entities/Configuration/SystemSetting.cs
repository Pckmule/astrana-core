/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.System.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.SystemSettings.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Settings", Schema = SchemaNames.Configuration)]
    public class SystemSetting : BaseEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.SystemSetting.MinimumNameLength)]
        [MaxLength(DomainModelProperties.SystemSetting.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [Column(Order = 2)]
        public SystemDataType DataType { get; set; }
        
        [MinLength(DomainModelProperties.SystemSetting.MinimumShortDescriptionLength)]
        [MaxLength(DomainModelProperties.SystemSetting.MaximumShortDescriptionLength)]
        [Column(Order = 3)]
        public string? ShortDescription { get; set; }
        
        [MinLength(DomainModelProperties.SystemSetting.MinimumHelpTextLength)]
        [MaxLength(DomainModelProperties.SystemSetting.MaximumHelpTextLength)]
        [Column(Order = 4)]
        public string? HelpText { get; set; }

        [Required]
        [MinLength(DomainModelProperties.SystemSetting.MinimumDefaultValueLength)]
        [MaxLength(DomainModelProperties.SystemSetting.MaximumDefaultValueLength)]
        [Column(Order = 5)]
        public string DefaultValue { get; set; }

        [Column(Order = 6)]
        [MinLength(DomainModelProperties.SystemSetting.MinimumValueLength)]
        [MaxLength(DomainModelProperties.SystemSetting.MaximumValueLength)]
        public string? Value { get; set; }

        public SystemSettingCategory SettingCategory { get; set; }
    }
}