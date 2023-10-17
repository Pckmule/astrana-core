/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files.Contracts;

namespace Astrana.Core.Domain.Files.Builders
{
    public static class FileProxyUrlBuilder
    {
        public static string GetUrl(string fileId, string fileExtension)
        {
            return "/" + fileId + "." + fileExtension.ToLower();
        }

        public static string GetUrl(IUploadedFile file)
        {
            return GetUrl(file.Id.ToString(), file.Type);
        }
    }
}
