/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.UserAccounts.Constants;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.DomainTransferObjects;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.UserAccounts
{
    public sealed class UserAccount : DomainEntity, IUserAccount, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public UserAccount()
        {
            NameUnique = ModelProperties.UserAccount.NameUnique;
            NameSingularForm = ModelProperties.UserAccount.NameSingularForm;
            NamePluralForm = ModelProperties.UserAccount.NamePluralForm;
        }
        
        public UserAccount(UserAccountDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                UserAccountId = dto.Id.Value;

            if (dto.Type.HasValue)
                Type = dto.Type.Value;

            if (!string.IsNullOrEmpty(dto.UserName))
                UserName = dto.UserName;

            if (!string.IsNullOrEmpty(dto.EmailAddress))
                EmailAddress = dto.EmailAddress;

            if (dto.IsEmailAddressConfirmed.HasValue)
                IsEmailAddressConfirmed = dto.IsEmailAddressConfirmed.Value;

            if (!string.IsNullOrEmpty(dto.PhoneCountryCodeISO))
                PhoneCountryCodeISO = dto.PhoneCountryCodeISO;

            if (!string.IsNullOrEmpty(dto.PhoneNumber))
                PhoneNumber = dto.PhoneNumber;

            if (dto.IsPhoneNumberConfirmed.HasValue)
                IsPhoneNumberConfirmed = dto.IsPhoneNumberConfirmed.Value;

            if (dto.IsTwoFactorEnabled.HasValue)
                IsTwoFactorEnabled = dto.IsTwoFactorEnabled.Value;

            if (dto.IsLockoutEnabled.HasValue)
                IsLockoutEnabled = dto.IsLockoutEnabled.Value;

            if (!string.IsNullOrEmpty(dto.CountryCode))
                CountryCode = dto.CountryCode;

            if (dto.CreatedBy.HasValue)
                CreatedBy = dto.CreatedBy.Value;

            if (dto.CreatedTimestamp.HasValue)
                CreatedTimestamp = dto.CreatedTimestamp.Value;

            if (dto.LastModifiedBy.HasValue)
                LastModifiedBy = dto.LastModifiedBy.Value;

            if (dto.LastModifiedTimestamp.HasValue)
                LastModifiedTimestamp = dto.LastModifiedTimestamp.Value;

            if (dto.DeactivatedTimestamp.HasValue)
                DeactivatedTimestamp = dto.DeactivatedTimestamp;

            if (dto.DeactivatedBy.HasValue)
                DeactivatedBy = dto.DeactivatedBy;

            if (!string.IsNullOrEmpty(dto.DeactivatedReason))
                DeactivatedReason = dto.DeactivatedReason;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        public UserAccount(UserAccountToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            UserAccountId = Guid.Empty;

            if (dto.Type.HasValue)
                Type = dto.Type.Value;

            if (!string.IsNullOrEmpty(dto.UserName))
                UserName = dto.UserName;

            if (!string.IsNullOrEmpty(dto.EmailAddress))
                EmailAddress = dto.EmailAddress;

            if (!string.IsNullOrEmpty(dto.PhoneCountryCodeISO))
                PhoneCountryCodeISO = dto.PhoneCountryCodeISO;

            if (!string.IsNullOrEmpty(dto.PhoneNumber))
                PhoneNumber = dto.PhoneNumber;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public Guid UserAccountId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        public UserAccountType Type { get; set; }

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumUsernameLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumUsernameLength)]
        public string UserName { get; set; }

        public string NormalizedUserName => UserName.ToUpper();

        [Required]
        [EmailAddress]
        [MinLength(ModelProperties.UserAccount.MinimumEmailAddressLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumEmailAddressLength)]
        public string EmailAddress { get; set; }

        public string NormalizedEmailAddress => EmailAddress.ToUpper();

        public bool IsEmailAddressConfirmed { get; set; }

        [DataType(DataType.Password)]
        [MinLength(ModelProperties.UserAccount.MinimumPasswordLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumPasswordLength)]
        public string Password { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        [MinLength(ModelProperties.UserAccount.MinimumPhoneCountryCodeISOLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumPhoneCountryCodeISOLength)]
        public string PhoneCountryCodeISO { get; set; }

        [Phone]
        [MinLength(ModelProperties.UserAccount.MinimumPhoneNumberLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        public bool IsPhoneNumberConfirmed { get; set; }

        public bool IsTwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool IsLockoutEnabled { get; set; }

        public short FailedAccessCount { get; set; }

        public string TimeZone { get; set; }

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumCountryCodeLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumCountryCodeLength)]
        public string CountryCode { get; set; }

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumLanguageCodeLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumLanguageCodeLength)]
        public string LanguageCode { get; set; }

        public DateTimeOffset? LastLoginTimestamp { get; set; }

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

        public override UserAccountDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public UserAccountDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new UserAccountDto
            {
                Type = Type,
                
                UserName = UserName,
                NormalizedUserName = NormalizedUserName,

                EmailAddress = EmailAddress,
                NormalizedEmailAddress = NormalizedEmailAddress,
                IsEmailAddressConfirmed = IsEmailAddressConfirmed,

                PhoneCountryCodeISO = PhoneCountryCodeISO,
                PhoneNumber = PhoneNumber,
                IsPhoneNumberConfirmed = IsPhoneNumberConfirmed,
                
                IsTwoFactorEnabled= IsTwoFactorEnabled,

                LockoutEnd = LockoutEnd,
                IsLockoutEnabled= IsLockoutEnabled,
                FailedAccessCount = FailedAccessCount,
                
                TimeZone = TimeZone,
                CountryCode = CountryCode,
                LanguageCode = LanguageCode,

                LastLoginTimestamp = LastLoginTimestamp
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

            if (!includeDeactivationData)
                return dto;

            dto.DeactivatedTimestamp = DeactivatedTimestamp;
            dto.DeactivatedBy = DeactivatedBy;
            dto.DeactivatedReason = DeactivatedReason;

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}