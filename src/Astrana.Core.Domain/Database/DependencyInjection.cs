/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Database.Commands.TestConnection;
using Astrana.Core.Domain.Database.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Database
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<ITestDatabaseConnectionCommand, TestDatabaseConnectionCommand>();
            services.AddTransient<ITestDatabaseConnectionCommand, TestDatabaseConnectionCommand>();

            services.AddScoped<IGetDatabaseSettingsQuery, GetDatabaseSettingsQuery>();
            services.AddTransient<IGetDatabaseSettingsQuery, GetDatabaseSettingsQuery>();

            return services;
        }
    }
}
