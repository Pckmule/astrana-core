/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Languages.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Languages
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetLanguagesQuery, GetLanguagesQuery>();
            services.AddTransient<IGetLanguagesQuery, GetLanguagesQuery>();

            return services;
        }
    }
}
