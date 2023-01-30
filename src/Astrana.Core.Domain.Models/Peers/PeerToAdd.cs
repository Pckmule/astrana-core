/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Peers
{
    public class PeerToAdd : BaseDomainModel, IPeerToAdd
    {
        public PeerToAdd()
        {
            NameUnique = ModelProperties.Peer.NameUnique;
            NameSingularForm = ModelProperties.Peer.NameSingularForm;
            NamePluralForm = ModelProperties.Peer.NamePluralForm;
        }

        /// <summary>
        /// The first name of owner of the Astrana peer instance to connect to.
        /// </summary> 
        /// <example>John</example>
        [Required]
        [MinLength(ModelProperties.Peer.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.Peer.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of owner of the Astrana peer instance to connect to.
        /// </summary> 
        /// <example>Smith</example>
        [Required]
        [MinLength(ModelProperties.Peer.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.Peer.MaximumFirstNameLength)]
        public string LastName { get; set; }

        /// <summary>
        /// The address of the Astrana peer instance to connect to.
        /// </summary> 
        /// <example>https://astrana.local</example>
        [Required]
        [MinLength(ModelProperties.Peer.MinimumAddressLength)]
        [MaxLength(ModelProperties.Peer.MaximumAddressLength)]
        public string Address { get; set; }

        /// <summary>
        /// An optional note about the Astrana peer instance.
        /// </summary> 
        /// <example>Remember me? We met at Jane's birthday party.</example>
        [MinLength(ModelProperties.Peer.MinimumNoteLength)]
        [MaxLength(ModelProperties.Peer.MaximumNoteLength)]
        public string Note { get; set; }

        [MaxLength(ModelProperties.Peer.MaximumPeerAccessTokenLength)]
        public string PeerAccessToken { get; set; }

        [Required]
        public bool IsMuted { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}