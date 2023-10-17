/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.AstranaApi.Commands.CreateApiAccessToken;
using Astrana.Core.Domain.AstranaApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.AstranaApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IAstranaApiCaller, AstranaApiClient>();
            services.AddTransient<IAstranaApiCaller, AstranaApiClient>();

            services.AddScoped<ICreateApiAccessTokenCommand, CreateApiAccessTokenCommand>();
            services.AddTransient<ICreateApiAccessTokenCommand, CreateApiAccessTokenCommand>();

            return services;
        }
    }
}
