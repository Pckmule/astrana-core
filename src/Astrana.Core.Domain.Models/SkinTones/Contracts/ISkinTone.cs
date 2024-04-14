/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.SkinTones.Contracts
{
    public interface ISkinTone
    {
        Guid SkinToneId { get; set; }

        string Name { get; set; }

        string NameTrxCode { get; set; }

        string ColorCode { get; set; }

        string Description { get; set; }

        string DescriptionTrxCode { get; set; }
    }
}
