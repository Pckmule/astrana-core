﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services, IConfiguration? configuration = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            Database.DependencyInjection.Register(services);
            SystemSettings.DependencyInjection.Register(services);
            IdentityAccessManagement.DependencyInjection.Register(services);
            AstranaApi.DependencyInjection.Register(services);
            Lookups.DependencyInjection.Register(services);
            Languages.DependencyInjection.Register(services);
            Countries.DependencyInjection.Register(services);
            UserAccounts.DependencyInjection.Register(services);
            UserProfiles.DependencyInjection.Register(services);
            UserPreferences.DependencyInjection.Register(services);
            SystemSetup.DependencyInjection.Register(services);
            Peers.DependencyInjection.Register(services);
            Posts.DependencyInjection.Register(services);
            MainFeed.DependencyInjection.Register(services);

            return services;
        }
    }
}