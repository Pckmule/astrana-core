/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Attributes;
using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Identity;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.UserProfiles.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.User
{
    [Table("UserProfiles", Schema = SchemaNames.User)]
    public class UserProfile: BaseEntity<Guid, Guid>
    {
        [Required]
        [Column(Order = 1)]
        public Guid UserAccountId { get; set; }

        [Column(Order = 2)]
        public UserAccount UserAccount { get; set; }

        [Required]
        [PersonalData]
        [MinLength(DomainModelProperties.UserProfile.MinimumFirstNameLength)]
        [MaxLength(DomainModelProperties.UserProfile.MaximumFirstNameLength)]
        [Column(Order = 3)]
        public string FirstName { get; set; }

        [PersonalData]
        [MaxLength(DomainModelProperties.UserProfile.MaximumMiddleNamesLength)]
        [Column(Order = 4)]
        public string MiddleNames { get; set; }

        [PersonalData]
        [MaxLength(DomainModelProperties.UserProfile.MaximumLastNameLength)]
        [Column(Order = 5)]
        public string LastName { get; set; }

        [PersonalData]
        [DataType(DataType.Date)]
        [Column(Order = 6)]
        public DateTimeOffset DateOfBirth { get; set; }

        [PersonalData]
        [Column(Order = 7)]
        public Gender Gender { get; set; }

        [PersonalData]
        [MaxLength(DomainModelProperties.UserProfile.MaximumIntroductionLength)]
        [Column(Order = 8)]
        public string Introduction { get; set; }

        [Column(Order = 9)]
        public Image ProfilePicture { get; set; }

        [Column(Order = 10)]
        public Image CoverPicture { get; set; }
    }
}