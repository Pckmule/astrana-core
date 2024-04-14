/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model.Validation;
using System.Text.Json.Serialization;

namespace Astrana.Core.Framework.Model
{
    public abstract class InputModelBase : IValidatable
    {
        public virtual EntityValidationResult Validate()
        {
            throw new NotImplementedException();
        }

        [JsonIgnore]
        public bool IsValid => Validate().IsSuccess;
    }
}
