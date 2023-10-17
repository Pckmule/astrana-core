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
    public class SystemSettingCategory : BaseEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.SystemSettingCategory.MinimumNameLength)]
        [MaxLength(DomainModelProperties.SystemSettingCategory.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [MinLength(DomainModelProperties.SystemSettingCategory.MinimumDescriptionLength)]
        [MaxLength(DomainModelProperties.SystemSettingCategory.MaximumDescriptionLength)]
        [Column(Order = 2)]
        public string? Description { get; set; }

        [Required]
        [Column(Order = 3)]
        public ICollection<SystemSetting> Settings { get; set; }
    }
}