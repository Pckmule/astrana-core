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
    public class SystemSetting
    {
        [Key, Column(Order = 0)]
        public Guid SystemSettingId { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumNameLength)]
        public string Name { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumNameLength)]
        public string NameTrxCode { get; set; }

        public SystemDataType DataType { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumShortDescriptionLength)]
        public string ShortDescription { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MaximumShortDescriptionTrxCodeLength)]
        public string ShortDescriptionTrxCode { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumHelpTextLength)]
        public string HelpText { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumHelpTextTrxCodeLength)]
        public string HelpTextTrxCode { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumDefaultValueLength)]
        public string DefaultValue { get; set; }

        [MinLength(DomainModelProperties.SystemSetting.MinimumValueLength)]
        public string Value { get; set; }
        
        [MinLength(DomainModelProperties.SystemSetting.MinimumValueOptionsLookupNameLength)]
        public string ValueChoicesLookupName { get; set; }

        public int? MaximumValues { get; set; }

        public int? MinimumValues { get; set; }

        public int? MaximumValueLength { get; set; }

        public int? MinimumValueLength { get; set; }

        public Guid? SettingCategoryId { get; set; }

        public SystemSettingCategory SettingCategory { get; set; }

        public bool UserMaySet { get; set; }
        
        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}