/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.SystemSetup.Commands.SetupInstance;
using Astrana.Core.Domain.SystemSetup.Commands.SetupInstanceUser;
using Astrana.Core.Domain.SystemSetup.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.SystemSetup
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetSystemSetupStatusQuery, GetSystemSetupStatusQuery>();
            services.AddTransient<IGetSystemSetupStatusQuery, GetSystemSetupStatusQuery>();

            services.AddScoped<IGetSystemSetupSuggestedDefaultsQuery, GetSystemSetupSuggestedDefaultsQuery>();
            services.AddTransient<IGetSystemSetupSuggestedDefaultsQuery, GetSystemSetupSuggestedDefaultsQuery>();

            services.AddScoped<ISetupInstanceUserCommand, SetupInstanceUserCommand>();
            services.AddTransient<ISetupInstanceUserCommand, SetupInstanceUserCommand>();

            services.AddScoped<ISetupInstanceCommand, SetupInstanceCommand>();
            services.AddTransient<ISetupInstanceCommand, SetupInstanceCommand>();

            return services;
        }
    }
}
