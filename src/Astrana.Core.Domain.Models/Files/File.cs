/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files.Constants;
using Astrana.Core.Domain.Models.Files.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Files
{
    // DTO?
    public class File : DomainEntity, IFile
    {
        [JsonConstructor]
        public File() { }

        public File(Guid id, string name, string type, string url, long? fileSizeBytes = 0, long? width = 0, long? height = 0)
        {
            Id = id;
            Name = name;
            Type = type;
            Url = url;
            FileSizeBytes = fileSizeBytes;
            Width = width;
            Height = height;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(ModelProperties.File.MinimumNameLength)]
        [MaxLength(ModelProperties.File.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.File.MinimumTypeLength)]
        [MaxLength(ModelProperties.File.MaximumTypeLength)]
        public string Type { get; set; }

        [Required]
        [MinLength(ModelProperties.File.MinimumUrlLength)]
        [MaxLength(ModelProperties.File.MaximumUrlLength)]
        public string Url { get; set; }

        public long? FileSizeBytes { get; set; }

        public long? Width { get; set; }

        public long? Height { get; set; }

        public new virtual EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}