/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.SystemSettings.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("SettingCategories", Schema = SchemaNames.Configuration)]
    public class SystemSettingCategory
    {
        [Key, Column(Order = 0)]
        public Guid SystemSettingCategoryId { get; set; }

        [MinLength(DomainModelProperties.SystemSettingCategory.MinimumNameLength)]
        public string Name { get; set; }

        [MinLength(DomainModelProperties.SystemSettingCategory.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [MinLength(DomainModelProperties.SystemSettingCategory.MinimumDescriptionLength)]
        public string? Description { get; set; }

        public string? DescriptionTrxCode { get; set; }

        public ICollection<SystemSetting> Settings { get; set; } = new HashSet<SystemSetting>();
        
        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}