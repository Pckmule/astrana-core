/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Notifications.Constants;
using Astrana.Core.Domain.Models.Notifications.Contracts;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Notifications
{
    public sealed class Notification : DomainAggregateEntity<Guid, NotificationDto>, INotification, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Notification()
        {
            NameUnique = ModelProperties.Notification.NameUnique;
            NameSingularForm = ModelProperties.Notification.NameSingularForm;
            NamePluralForm = ModelProperties.Notification.NamePluralForm;
        }

        public Notification(NotificationDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                NotificationId = dto.Id.Value;

            if (dto.Type.HasValue)
                Type = dto.Type.Value;

            if (!string.IsNullOrEmpty(dto.Message))
                Message = dto.Message;

            if (dto.SourceType.HasValue)
                SourceType = dto.SourceType.Value;

            if (!string.IsNullOrEmpty(dto.SourceId))
                SourceId = dto.SourceId;

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

        public Notification(AddNotificationDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            NotificationId = Guid.Empty;

            if (dto.Type.HasValue)
                Type = dto.Type.Value;

            if (!string.IsNullOrEmpty(dto.Message))
                Message = dto.Message;

            if (dto.SourceType.HasValue)
                SourceType = dto.SourceType.Value;

            if (!string.IsNullOrEmpty(dto.SourceId))
                SourceId = dto.SourceId;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public Guid NotificationId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        public NotificationType Type { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public NotificationSourceType SourceType { get; set; }

        [Required]
        public string SourceId { get; set; }

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

        public override NotificationDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public NotificationDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new NotificationDto
            {
                Type = Type,
                Message = Message
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