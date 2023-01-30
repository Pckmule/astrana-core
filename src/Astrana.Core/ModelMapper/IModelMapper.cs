/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.ModelMapper
{
    public interface IModelMapper
    {
        IEnumerable<TNewModel> MapModels<TNewModel, TCurrentModel>(IEnumerable<TCurrentModel> currentModels)
            where TNewModel : class
            where TCurrentModel : class;

        TNewModel MapModel<TNewModel, TCurrentModel>(TCurrentModel currentModel)
            where TNewModel : class
            where TCurrentModel : class;
    }
}