/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

#nullable disable

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.ApiAccessTokens.Constants.ModelProperties;

namespace Astrana.Core.Data.Entities.AccessManagement
{
    [Table("ApiAccessTokens", Schema = SchemaNames.IdentityAccessManagement)]
    public class ApiAccessToken
    {
        [Key, Column(Order = 0)]
        public Guid ApiAccessTokenId { get; set; }
        
        [MinLength(DomainModelProperties.ApiAccessToken.MinimumTokenLength)]
        public virtual string Token { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}