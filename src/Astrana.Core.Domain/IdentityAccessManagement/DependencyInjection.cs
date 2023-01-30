/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.IdentityAccessManagement
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IIdpManager, IdpManager>();
            services.AddTransient<IIdpManager, IdpManager>();

            services.AddScoped<ISignInManager, SignInManager>();
            services.AddTransient<ISignInManager, SignInManager>();

            services.AddScoped<IUserManager, UserManager>();
            services.AddTransient<IUserManager, UserManager>();

            return services;
        }
    }
}
