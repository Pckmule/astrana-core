/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Files.Contracts
{
    public interface IProcessedFile
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Type { get; set; }

        string Url { get; set; }
    }
}
