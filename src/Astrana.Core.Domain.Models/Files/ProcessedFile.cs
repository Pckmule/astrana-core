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
    public class ProcessedFile : DomainEntity, IProcessedFile
    {
        [JsonConstructor]
        public ProcessedFile() { }

        public ProcessedFile(File file)
        {
            Id = file.Id;
            Name = file.Name;
            Type = file.Type;
            Url = file.Url;
        }

        public ProcessedFile(Guid id, string name, string type, string url)
        {
            Id = id;
            Name = name;
            Type = type;
            Url = url;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(ModelProperties.ProcessedFile.MinimumNameLength)]
        [MaxLength(ModelProperties.ProcessedFile.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.ProcessedFile.MinimumTypeLength)]
        [MaxLength(ModelProperties.ProcessedFile.MaximumTypeLength)]
        public string Type { get; set; }

        [Required]
        [MinLength(ModelProperties.ProcessedFile.MinimumUrlLength)]
        [MaxLength(ModelProperties.ProcessedFile.MaximumUrlLength)]
        public string Url { get; set; }

        public string VirusScanResult { get; set; }

        public new virtual EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}