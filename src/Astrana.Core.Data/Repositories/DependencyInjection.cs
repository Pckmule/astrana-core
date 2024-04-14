/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ApiAccessTokens;
using Astrana.Core.Data.Repositories.Audiences;
using Astrana.Core.Data.Repositories.AudioClips;
using Astrana.Core.Data.Repositories.Audios;
using Astrana.Core.Data.Repositories.Comments;
using Astrana.Core.Data.Repositories.ContentCollections;
using Astrana.Core.Data.Repositories.Countries;
using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Data.Repositories.Feelings;
using Astrana.Core.Data.Repositories.Images;
using Astrana.Core.Data.Repositories.Languages;
using Astrana.Core.Data.Repositories.Links;
using Astrana.Core.Data.Repositories.NewContentWorkflowStages;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Data.Repositories.TimeZones;
using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Data.Repositories.Videos;
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

            services.AddScoped<ITimeZoneRepository<Guid>, TimeZoneRepository>();
            services.AddTransient<ITimeZoneRepository<Guid>, TimeZoneRepository>();

            services.AddScoped<ICountryRepository<Guid>, CountryRepository>();
            services.AddTransient<ICountryRepository<Guid>, CountryRepository>();

            services.AddScoped<IFeelingRepository<Guid>, FeelingRepository>();
            services.AddTransient<IFeelingRepository<Guid>, FeelingRepository>();

            services.AddScoped<IUserAccountRepository<Guid>, UserAccountRepository>();
            services.AddTransient<IUserAccountRepository<Guid>, UserAccountRepository>();

            services.AddScoped<IUserProfileRepository<Guid>, UserProfileRepository>();
            services.AddTransient<IUserProfileRepository<Guid>, UserProfileRepository>();

            services.AddScoped<IPeerRepository<Guid>, PeerRepository>();
            services.AddTransient<IPeerRepository<Guid>, PeerRepository>();

            services.AddScoped<IAudienceRepository<Guid>, AudienceRepository>();
            services.AddTransient<IAudienceRepository<Guid>, AudienceRepository>();

            services.AddScoped<INewContentWorkflowStageRepository<Guid>, NewContentWorkflowStageRepository>();
            services.AddTransient<INewContentWorkflowStageRepository<Guid>, NewContentWorkflowStageRepository>();

            services.AddScoped<ILinkRepository<Guid>, LinkRepository>();
            services.AddTransient<ILinkRepository<Guid>, LinkRepository>();

            services.AddScoped<IImageRepository<Guid>, ImageRepository>();
            services.AddTransient<IImageRepository<Guid>, ImageRepository>();

            services.AddScoped<IVideoRepository<Guid>, VideoRepository>();
            services.AddTransient<IVideoRepository<Guid>, VideoRepository>();

            services.AddScoped<IAudioRepository<Guid>, AudioRepository>();
            services.AddTransient<IAudioRepository<Guid>, AudioRepository>();

            // services.AddScoped<IPostRepository<Guid>, PostRepository>();
            // services.AddTransient<IPostRepository<Guid>, PostRepository>();

            services.AddScoped<ICommentRepository<Guid>, CommentRepository>();
            services.AddTransient<ICommentRepository<Guid>, CommentRepository>();

            services.AddScoped<IContentCollectionRepository<Guid>, ContentCollectionRepository>();
            services.AddTransient<IContentCollectionRepository<Guid>, ContentCollectionRepository>();

            services.AddScoped<IExternalContentSubscriptionRepository<Guid>, ExternalContentSubscriptionRepository>();
            services.AddTransient<IExternalContentSubscriptionRepository<Guid>, ExternalContentSubscriptionRepository>();

            services.AddScoped<IExternalContentSubscriptionContentItemRepository<Guid>, ExternalContentSubscriptionContentItemRepository>();
            services.AddTransient<IExternalContentSubscriptionContentItemRepository<Guid>, ExternalContentSubscriptionContentItemRepository>();

            return services;
        }
    }
}
