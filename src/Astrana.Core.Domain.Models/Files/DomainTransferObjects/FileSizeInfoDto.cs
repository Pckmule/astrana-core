/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Files.DomainTransferObjects
{
    public class FileSizeInfoDto
    {
        [JsonConstructor]
        public FileSizeInfoDto(long? sizeInBytes = 0, long? width = 0, long? height = 0)
        {
            Bytes = sizeInBytes;
            Width = width;
            Height = height;
        }

        public long? Bytes { get; set; }

        public long? Width { get; set; }

        public long? Height { get; set; }
    }
}