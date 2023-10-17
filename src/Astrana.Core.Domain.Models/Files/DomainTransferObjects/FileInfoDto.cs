/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Files.DomainTransferObjects
{
    public class FileInfoDto
    {
        [JsonConstructor]
        public FileInfoDto() { }

        public FileInfoDto(string name, string type, FileSizeInfoDto size = null)
        {
            Name = name;
            Extension = type;
            Size = size;
        }

        public string Name { get; set; }

        public string Extension { get; set; }

        public FileSizeInfoDto Size { get; set; }
    }
}