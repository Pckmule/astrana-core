/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Attributes;
using Astrana.Core.Data.Constants;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astrana.Core.Data.Entities.Configuration;
using DomainModelProperties = Astrana.Core.Domain.Models.UserProfiles.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.User
{
    [Table("UserProfileDetails", Schema = SchemaNames.User)]
    public class UserProfileDetail: BaseEntity<Guid, Guid>
    {
        [Required]
        [Column(Order = 1)]
        public Guid UserProfileId { get; set; }

        [Column(Order = 2)]
        public UserProfile UserProfile { get; set; }

        [Required]
        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumKeyLength)]
        [MaxLength(DomainModelProperties.UserProfileDetail.MaximumKeyLength)]
        [Column(Order = 3)]
        public string Key { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumLabelLength)]
        [MaxLength(DomainModelProperties.UserProfileDetail.MaximumLabelLength)]
        [Column(Order = 4)]
        public string Label { get; set; }

        [Required]
        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumValueLength)]
        [MaxLength(DomainModelProperties.UserProfileDetail.MaximumValueLength)]
        [Column(Order = 5)]
        public string Value { get; set; }

        [Required]
        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumIconNameLength)]
        [MaxLength(DomainModelProperties.UserProfileDetail.MaximumIconNameLength)]
        [Column(Order = 6)]
        public string IconName { get; set; }
        
        [Column(Order = 7)]
        public short? DisplayOrder { get; set; }

        [Column(Order = 8)]
        public Collection<Audience> Audiences { get; set; }
    }
}