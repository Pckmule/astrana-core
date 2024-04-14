/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.UserProfiles.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.User
{
    [Table("UserProfileDetails", Schema = SchemaNames.User)]
    public class UserProfileDetail
    {
        [Key, Column(Order = 0)]
        public Guid UserProfileDetailId { get; set; }

        public Guid UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumKeyLength)]
        public string Key { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumLabelLength)]
        public string Label { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumValueLength)]
        public string Value { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserProfileDetail.MinimumIconNameLength)]
        public string IconName { get; set; }
        
        public short? DisplayOrder { get; set; }

        public ICollection<Audience> Audiences { get; set; } = new HashSet<Audience>();
        
        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}