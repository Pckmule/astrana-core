/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Peers
{
    public sealed class PeerProfile : DomainEntity, IPeerProfile
    {
        public PeerProfile()
        {
            NameUnique = ModelProperties.PeerProfile.NameUnique;
            NameSingularForm = ModelProperties.PeerProfile.NameSingularForm;
            NamePluralForm = ModelProperties.PeerProfile.NamePluralForm;
        }

        public PeerProfile(PeerProfileDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                PeerProfileId = dto.Id.Value;

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

            if (dto.ProfilePicture != null)
                ProfilePicture = new Image(dto.ProfilePicture);

            if (dto.CoverPicture != null)
                CoverPicture = new Image(dto.CoverPicture);

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

        public PeerProfile(PeerProfileToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            PeerProfileId = Guid.Empty;

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

            if (dto.ProfilePicture != null)
                ProfilePicture = new Image(dto.ProfilePicture);

            if (dto.CoverPicture != null)
                CoverPicture = new Image(dto.CoverPicture);

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid PeerProfileId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumFirstNameLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumMiddleNamesLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumMiddleNamesLength)]
        public string MiddleNames { get; set; }

        [Required]
        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumLastNameLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumLastNameLength)]
        public string LastName { get; set; }

        [Required]
        [DateOfBirth]
        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        public Sex Sex { get; set; }

        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumIntroductionLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumIntroductionLength)]
        public string Introduction { get; set; }

        public Image? ProfilePicture { get; set; }

        public Image? CoverPicture { get; set; }

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

        public override PeerProfileDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public PeerProfileDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new PeerProfileDto
            {
                FirstName = FirstName,
                MiddleNames = MiddleNames,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                Sex = Sex,
                Introduction = Introduction,
                ProfilePicture = ProfilePicture?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),
                CoverPicture = CoverPicture?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData)
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