/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.ModelMapper.Exceptions;
using AutoMapper;

namespace Astrana.Core.ModelMapper
{
    public class ModelMapper : IModelMapper
    {
        public IConfigurationProvider Configuration { get; }

        public IMapper Mapper { get; }

        public ModelMapper(IConfigurationProvider configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration), "Mapper configuration is null.");
            Mapper = Configuration.CreateMapper();
        }

        /// <summary>
        /// Maps a lists of models to a list other models.
        /// </summary>
        /// <typeparam name="TNewModel"></typeparam>
        /// <typeparam name="TCurrentModel"></typeparam>
        /// <param name="currentModels"></param>
        /// <returns></returns>
        public IEnumerable<TNewModel> MapModels<TNewModel, TCurrentModel>(IEnumerable<TCurrentModel> currentModels) where TNewModel : class where TCurrentModel : class
        {
            return currentModels.Select(model => Mapper.Map<TCurrentModel, TNewModel>(model)).ToList();
        }

        /// <summary>
        /// Maps one class model to another.
        /// </summary>
        /// <typeparam name="TNewModel"></typeparam>
        /// <typeparam name="TCurrentModel"></typeparam>
        /// <param name="currentModel"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ModelMappingException"></exception>
        public TNewModel MapModel<TNewModel, TCurrentModel>(TCurrentModel currentModel) where TNewModel : class where TCurrentModel : class
        {
            if (currentModel == null)
                throw new ArgumentNullException(nameof(currentModel), $"No model to convert. {nameof(currentModel)} is null.");

            return MapModels<TNewModel, TCurrentModel>(new List<TCurrentModel> { currentModel }).FirstOrDefault() ?? throw new ModelMappingException($"Could not map {nameof(TCurrentModel)} to {nameof(TNewModel)}.");
        }
    }
}
