/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using Microsoft.AspNetCore.Http;

namespace Astrana.Core.Domain.Files.Queries.GetFileInfo
{
    public interface IGetFileInfoQuery
    {
        FileInfoDto Execute(IFormFile formFile);

        FileInfoDto Execute(string location);
    }
}
