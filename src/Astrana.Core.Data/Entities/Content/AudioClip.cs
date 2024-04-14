﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.AudioClips.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("AudioClips", Schema = SchemaNames.Content)]
    public class AudioClip
    {
        [Key, Column(Order = 0)]
        public Guid AudioClipId { get; set; }

        [MinLength(DomainModelProperties.AudioClip.MinimumLocationLength)]
        public string Location { get; set; }

        [MinLength(DomainModelProperties.AudioClip.MinimumCaptionLength)]
        public string Caption { get; set; }

        [MinLength(DomainModelProperties.AudioClip.MinimumCopyrightLength)]
        public string Copyright { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}