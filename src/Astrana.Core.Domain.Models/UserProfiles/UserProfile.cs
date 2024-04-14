/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.Models.UserProfiles.DomainTransferObjects;
using Astrana.Core.Domain.Models.UserProfiles.DomainTransferObjects;
using System.Drawing;
using System;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.UserProfiles
{
    public sealed class UserProfile : DomainEntity, IUserProfile, IAuditable<Guid>
    {
        public UserProfile()
        {
            NameUnique = ModelProperties.UserProfile.NameUnique;
            NameSingularForm = ModelProperties.UserProfile.NameSingularForm;
            NamePluralForm = ModelProperties.UserProfile.NamePluralForm;
        }

        public UserProfile(UserProfileDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ProfileId = dto.Id.Value;

            if (dto.UserAccountId.HasValue)
                UserAccountId = dto.UserAccountId.Value;

            if (!string.IsNullOrEmpty(dto.FirstName))
                FirstName = dto.FirstName;

            if (!string.IsNullOrEmpty(dto.MiddleNames))
                MiddleNames = dto.MiddleNames;

            if (!string.IsNullOrEmpty(dto.LastName))
                LastName = dto.LastName;

            if (dto.DateOfBirth.HasValue)
                DateOfBirth = dto.DateOfBirth.Value;

            if (dto.Sex.HasValue)
                Sex = dto.Sex.Value;

            if (!string.IsNullOrEmpty(dto.Introduction))
                Introduction = dto.Introduction;

            if (dto.ProfilePicturesCollection != null)
                ProfilePicturesCollection = new ContentCollection(dto.ProfilePicturesCollection);

            if (dto.CoverPicturesCollection != null)
                CoverPicturesCollection = new ContentCollection(dto.CoverPicturesCollection);

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

        public UserProfile(UserProfileToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            ProfileId = Guid.Empty;

            if (dto.UserAccountId.HasValue)
                UserAccountId = dto.UserAccountId.Value;

            if (!string.IsNullOrEmpty(dto.FirstName))
                FirstName = dto.FirstName;

            if (!string.IsNullOrEmpty(dto.MiddleNames))
                MiddleNames = dto.MiddleNames;

            if (!string.IsNullOrEmpty(dto.LastName))
                LastName = dto.LastName;

            if (dto.DateOfBirth.HasValue)
                DateOfBirth = dto.DateOfBirth.Value;

            if (dto.Sex.HasValue)
                Sex = dto.Sex.Value;

            if (!string.IsNullOrEmpty(dto.Introduction))
                Introduction = dto.Introduction;

            if (dto.ProfilePicturesCollection != null)
                ProfilePicturesCollection = new ContentCollection(dto.ProfilePicturesCollection);

            if (dto.CoverPicturesCollection != null)
                CoverPicturesCollection = new ContentCollection(dto.CoverPicturesCollection);

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public Guid ProfileId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        public Guid UserAccountId { get; set; }

        [Required]
        [MinLength(ModelProperties.UserProfile.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        [MinLength(ModelProperties.UserProfile.MinimumMiddleNamesLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumMiddleNamesLength)]
        public string MiddleNames { get; set; }

        [Required]
        [MinLength(ModelProperties.UserProfile.MinimumLastNameLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumLastNameLength)]
        public string LastName { get; set; }

        public string FullName => (FirstName + " " + LastName).Trim();

        [Required]
        [DateOfBirth]
        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset DateOfBirth { get; set; }

        [RequiredEnum]
        public Sex Sex { get; set; }

        [MinLength(ModelProperties.UserProfile.MinimumIntroductionLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumIntroductionLength)]
        public string Introduction { get; set; }
        
        public ContentCollection? ProfilePicturesCollection { get; set; }

        public ContentCollection? CoverPicturesCollection { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
        
        public UserProfileDto ToDomainTransferObject(bool includeId, bool includeAuditData)
        {
            var dto = new UserProfileDto
            {
                FirstName = FirstName,
                MiddleNames = MiddleNames,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                Sex = Sex,
                Introduction = Introduction,
                ProfilePicturesCollection = ProfilePicturesCollection?.ToDomainTransferObject(includeId, includeAuditData),
                CoverPicturesCollection = CoverPicturesCollection?.ToDomainTransferObject(includeId, includeAuditData),
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