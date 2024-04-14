/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.SystemSettings.DomainTransferObjects
{
    public sealed class SystemSettingDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public string? Name { get; set; }

        public string? NameTrxCode { get; set; }
        
        public SystemDataType? DataType { get; set; }

        public string? DefaultValue { get; set; }

        public string? Value { get; set; }

        public string? ShortDescription { get; set; }

        public string? ShortDescriptionTrxCode { get; set; }
        
        public string? HelpText { get; set; }

        public string? HelpTextTrxCode { get; set; }

        public int? MaximumValues { get; set; }

        public int? MinimumValues { get; set; }

        public int? MaximumValueLength { get; set; }

        public int? MinimumValueLength { get; set; }

        public Guid? SystemSettingCategoryId { get; set; }

        public bool? UserMaySet { get; set; }
        
        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }
    }
}