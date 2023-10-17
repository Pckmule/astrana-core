/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Reactions.Contracts
{
    public interface IReactionToAdd
    {
        string Name { get; set; }

        string NameTrxCode { get; set; }

        string IconName { get; set; }

        string UnicodeIcon { get; set; }
    }
}
