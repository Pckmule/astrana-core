/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
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
    public class UserProfile
    {
        [Key, Column(Order = 0)]
        public Guid UserProfileId { get; set; }

        [Required]
        public Guid UserAccountId { get; set; }

        public UserAccount UserAccount { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserProfile.MinimumFirstNameLength)]
        public string FirstName { get; set; }

        [PersonalData]
        public string MiddleNames { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        [DataType(DataType.Date)]
        public DateTimeOffset DateOfBirth { get; set; }

        [PersonalData]
        public Sex Sex { get; set; }

        [PersonalData]
        public string Introduction { get; set; }

        public Image ProfilePicture { get; set; }

        public ContentCollection ProfilePicturesCollection { get; set; }

        public Image CoverPicture { get; set; }
        
        public ContentCollection CoverPicturesCollection { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}