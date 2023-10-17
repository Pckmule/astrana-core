/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ProfilePicture.Commands.AddProfilePicture;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.ProfilePicture
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IAddProfilePictureCommand, AddProfilePictureCommand>();
            services.AddTransient<IAddProfilePictureCommand, AddProfilePictureCommand>();

            return services;
        }
    }
}
