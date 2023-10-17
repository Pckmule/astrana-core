/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.Enums;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using Astrana.Core.Utilities;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Peers
{
    public class PeerConnectionRequestReceived : DomainEntity, IPeerConnectionRequestReceived, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _address = "";

        public PeerConnectionRequestReceived()
        {
            NameUnique = ModelProperties.PeerConnectionRequestReceived.NameUnique;
            NameSingularForm = ModelProperties.PeerConnectionRequestReceived.NameSingularForm;
            NamePluralForm = ModelProperties.PeerConnectionRequestReceived.NamePluralForm;
        }

        public Guid PeerConnectionRequestReceivedId { get; set; }

        /// <summary>
        /// The first name of owner of the Astrana peer instance requesting to connect.
        /// </summary> 
        /// <example>John</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestReceived.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestReceived.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of owner of the Astrana peer instance requesting to connect.
        /// </summary> 
        /// <example>Smith</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestReceived.MinimumLastNameLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestReceived.MaximumLastNameLength)]
        public string LastName { get; set; }

        /// <summary>
        /// The address of the Astrana instance requesting to connect.
        /// </summary> 
        /// <example>https://astrana.local</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestReceived.MinimumAddressLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestReceived.MaximumAddressLength)]
        [SecureWebAddress]
        public string Address
        {
            get => _address;
            set => _address = value.AddHttpsScheme();
        }

        /// <summary>
        /// An optional note about the Astrana peer instance requesting to connect.
        /// </summary> 
        /// <example>Remember me? We met at Jane's birthday party.</example>
        [MinLength(ModelProperties.PeerConnectionRequestReceived.MinimumNoteLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestReceived.MaximumNoteLength)]
        public string Note { get; set; }

        /// <summary>
        /// A short lived access token for accessing preview information from the Astrana instance requesting to connect.
        /// </summary>
        [MaxLength(ModelProperties.PeerConnectionRequestReceived.MaximumPeerPreviewAccessTokenLength)]
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