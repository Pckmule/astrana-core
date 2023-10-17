/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfiles;
using Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfileDetails;
using Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileDetails;
using Astrana.Core.Domain.UserProfiles.Commands.DeleteUserProfileDetails;
using Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileIntroduction;
using Astrana.Core.Domain.UserProfiles.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.UserProfiles
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetUserProfileQuery, GetUserProfilesQuery>();
            services.AddTransient<IGetUserProfileQuery, GetUserProfilesQuery>();

            services.AddScoped<ICreateUserProfileCommand, CreateUserProfileCommand>();
            services.AddTransient<ICreateUserProfileCommand, CreateUserProfileCommand>();

            services.AddScoped<IUpdateUserProfileIntroductionCommand, UpdateUserProfileIntroductionCommand>();
            services.AddTransient<IUpdateUserProfileIntroductionCommand, UpdateUserProfileIntroductionCommand>();

            services.AddScoped<IGetUserProfileDetailsQuery, GetUserProfileDetailsQuery>();
            services.AddTransient<IGetUserProfileDetailsQuery, GetUserProfileDetailsQuery>();

            services.AddScoped<ICreateUserProfileDetailsCommand, CreateUserProfileDetailsCommand>();
            services.AddTransient<ICreateUserProfileDetailsCommand, CreateUserProfileDetailsCommand>();

            services.AddScoped<IUpdateUserProfileDetailsCommand, UpdateUserProfileDetailsCommand>();
            services.AddTransient<IUpdateUserProfileDetailsCommand, UpdateUserProfileDetailsCommand>();

            services.AddScoped<IDeleteUserProfileDetailsCommand, DeleteUserProfileDetailsCommand>();
            services.AddTransient<IDeleteUserProfileDetailsCommand, DeleteUserProfileDetailsCommand>();

            services.AddScoped<IGetProfilePhotosQuery, GetProfilePhotosQuery>();
            services.AddTransient<IGetProfilePhotosQuery, GetProfilePhotosQuery>();

            return services;
        }
    }
}
