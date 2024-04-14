/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.PhoneNumberTypes.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{

    [Table("PhoneNumberTypes", Schema = SchemaNames.Configuration)]
    public class PhoneNumberType
    {
        [Key, Column(Order = 0)]
        public Guid PhoneNumberTypeId { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.PhoneNumberType.MinimumNameLength)]
        public string Name { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.PhoneNumberType.MinimumCodeLength)]
        public string Code { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
