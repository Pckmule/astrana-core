/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using Astrana.Core.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Peers
{
    public class PeerConnectionRequestSubmitted : DomainEntity, IPeerConnectionRequestSubmitted, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _address = "";

        public PeerConnectionRequestSubmitted()
        {
            NameUnique = ModelProperties.PeerConnectionRequestSubmitted.NameUnique;
            NameSingularForm = ModelProperties.PeerConnectionRequestSubmitted.NameSingularForm;
            NamePluralForm = ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm;
        }

        public Guid PeerConnectionRequestSubmittedId { get; set; }

        /// <summary>
        /// The first name of owner of the Astrana peer instance submitting the connection request.
        /// </summary> 
        /// <example>John</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of owner of the Astrana peer instance submitting the connection request.
        /// </summary> 
        /// <example>Smith</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumLastNameLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumLastNameLength)]
        public string LastName { get; set; }

        /// <summary>
        /// The address of the Astrana instance to submit the request connection to.
        /// </summary> 
        /// <example>https://astrana.local</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumAddressLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumAddressLength)]
        [SecureWebAddress]
        public string Address
        {
            get => _address;
            set => _address = value.AddHttpsScheme();
        }

        /// <summary>
        /// An optional note about the Astrana peer instance submitting the connection request.
        /// </summary> 
        /// <example>Remember me? We met at Jane's birthday party.</example>
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumNoteLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumNoteLength)]
        public string Note { get; set; }

        /// <summary>
        /// The short lived access token for accessing preview information from the Astrana instance submitting the connection request.
        /// </summary>
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumPeerPreviewAccessTokenLength)]
        public string PeerPreviewAccessToken { get; set; }

        /// <summary>
        /// The status of the connection request.
        /// </summary>
        [Required]
        public PeerConnectionRequestStatus Status { get; set; }

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

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}