/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ApiAccessTokens;
using Astrana.Core.Data.Repositories.Countries;
using Astrana.Core.Data.Repositories.Languages;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Data.Repositories.Posts;
using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Data.Repositories.UserProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Data.Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISystemSettingRepository<Guid>, SystemSettingRepository>();
            services.AddTransient<ISystemSettingRepository<Guid>, SystemSettingRepository>();

            services.AddScoped<IApiAccessTokenRepository<Guid>, ApiAccessTokenRepository>();
            services.AddTransient<IApiAccessTokenRepository<Guid>, ApiAccessTokenRepository>();

            services.AddScoped<ILanguageRepository<Guid>, LanguageRepository>();
            services.AddTransient<ILanguageRepository<Guid>, LanguageRepository>();

            services.AddScoped<ICountryRepository<Guid>, CountryRepository>();
            services.AddTransient<ICountryRepository<Guid>, CountryRepository>();

            services.AddScoped<IUserAccountRepository<Guid>, UserAccountRepository>();
            services.AddTransient<IUserAccountRepository<Guid>, UserAccountRepository>();

            services.AddScoped<IUserProfileRepository<Guid>, UserProfileRepository>();
            services.AddTransient<IUserProfileRepository<Guid>, UserProfileRepository>();

            services.AddScoped<IPeerRepository<Guid>, PeerRepository>();
            services.AddTransient<IPeerRepository<Guid>, PeerRepository>();

            services.AddScoped<IPostRepository<Guid>, PostRepository>();
            services.AddTransient<IPostRepository<Guid>, PostRepository>();

            return services;
        }
    }
}
