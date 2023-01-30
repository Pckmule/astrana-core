/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfiles;
using Astrana.Core.Domain.UserProfiles.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.UserProfiles
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetUserProfileQuery, GetUserProfileQuery>();
            services.AddTransient<IGetUserProfileQuery, GetUserProfileQuery>();

            services.AddScoped<ICreateUserProfileCommand, CreateUserProfileCommand>();
            services.AddTransient<ICreateUserProfileCommand, CreateUserProfileCommand>();

            return services;
        }
    }
}
