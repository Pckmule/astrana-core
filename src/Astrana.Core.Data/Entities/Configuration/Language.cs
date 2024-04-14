/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Languages.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Languages", Schema = SchemaNames.Configuration)]
    public class Language
    {
        [Key, Column(Order = 0)]
        public Guid LanguageId { get; set; }

        [MinLength(DomainModelProperties.Language.MinimumNameLength)]
        public string Name { get; set; }
        
        [MinLength(DomainModelProperties.Language.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }
        
        [MinLength(DomainModelProperties.Language.MinimumTwoLetterCodeLength)]
        public string TwoLetterCode { get; set; }

        [MinLength(DomainModelProperties.Language.MinimumThreeLetterCodeLength)]
        public string ThreeLetterCode { get; set; }

        public LanguageDirection Direction { get; set; }

        // public ICollection<Country> Countries { get; set; } = new HashSet<Country>();
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }
        
        public string DeactivatedReason { get; set; } = null;
        
        public Guid? DeactivatedBy { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid LastModifiedBy { get; set; }
        
        public DateTimeOffset CreatedTimestamp { get; set; }
        
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
