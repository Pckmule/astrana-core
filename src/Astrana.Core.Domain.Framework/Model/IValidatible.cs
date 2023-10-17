/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Framework.Model
{
    public interface IValidatable
    {
        EntityValidationResult Validate();

        bool IsValid { get; }
    }
}