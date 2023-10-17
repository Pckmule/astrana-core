/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files.Constants;
using Astrana.Core.Domain.Models.Files.Contracts;
using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Files
{
    public class UploadedFile : DomainEntity, IUploadedFile
    {
        [JsonConstructor]
        public UploadedFile() { }

        public UploadedFile(File file)
        {
            Id = file.Id;
            Name = file.Name;
            Type = file.Type;
            Location = file.Url;
            FileSizeBytes = file.FileSizeBytes;
            Width = file.Width;
            Height = file.Height;
        }

        public UploadedFile(Guid id, string url, FileInfoDto fileInfoDto)
        {
            Id = id;
            Name = fileInfoDto.Name;
            Type = fileInfoDto.Extension;
            Location = url;
            FileSizeBytes = fileInfoDto.Size.Bytes;
            Width = fileInfoDto.Size.Width;
            Height = fileInfoDto.Size.Height;
        }

        public UploadedFile(Guid id, string name, string type, string url, long? fileSizeBytes = 0, long? width = 0, long? height = 0)
        {
            Id = id;
            Name = name;
            Type = type;
            Location = url;
            FileSizeBytes = fileSizeBytes;
            Width = width;
            Height = height;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(ModelProperties.UploadedFile.MinimumNameLength)]
        [MaxLength(ModelProperties.UploadedFile.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.UploadedFile.MinimumTypeLength)]
        [MaxLength(ModelProperties.UploadedFile.MaximumTypeLength)]
        public string Type { get; set; }

        [Required]
        [MinLength(ModelProperties.UploadedFile.MinimumUrlLength)]
        [MaxLength(ModelProperties.UploadedFile.MaximumUrlLength)]
        public string Location { get; set; }

        public long? FileSizeBytes { get; set; }

        public long? Width { get; set; }

        public long? Height { get; set; }

        public string VirusScanResult { get; set; }
        
        public Dictionary<string, object> Metadata { get; set; } = new();

        public new virtual EntityValidationResult Validate()
        {
            var validationResult = this.ValidateDomainModel();

            if (VirusScanResult == "VirusFound")
                validationResult.FailedValidations.Add(new EntityValidationResult(nameof(UploadedFile), ValidatedEntityType.DomainModel, message: $"File is not safe: {VirusScanResult}", outcome: ValidationOutcome.Failed));

            return validationResult;
        }
    }
}