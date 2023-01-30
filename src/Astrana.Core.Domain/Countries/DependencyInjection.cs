/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Countries.Commands.CreateCountries;
using Astrana.Core.Domain.Countries.Commands.DeleteCountries;
using Astrana.Core.Domain.Countries.Commands.UpdateCountries;
using Astrana.Core.Domain.Countries.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Countries
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetCountriesQuery, GetCountriesQuery>();
            services.AddTransient<IGetCountriesQuery, GetCountriesQuery>();

            services.AddScoped<ICreateCountriesCommand, CreateCountriesCommand>();
            services.AddTransient<ICreateCountriesCommand, CreateCountriesCommand>();

            services.AddScoped<IUpdateCountriesCommand, UpdateCountriesCommand>();
            services.AddTransient<IUpdateCountriesCommand, UpdateCountriesCommand>();

            services.AddScoped<IDeleteCountriesCommand, DeleteCountriesCommand>();
            services.AddTransient<IDeleteCountriesCommand, DeleteCountriesCommand>();

            return services;
        }
    }
}
