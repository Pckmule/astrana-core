/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.ComposeFeed;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.CreateExternalSubscriptions;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.DeleteExternalSubscriptions;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.UpdateExternalSubscriptions;
using Astrana.Core.Domain.ExternalContentSubscriptions.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.ExternalContentSubscriptions
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetExternalSubscriptionsQuery, GetExternalContentSubscriptionsQuery>();
            services.AddTransient<IGetExternalSubscriptionsQuery, GetExternalContentSubscriptionsQuery>();

            services.AddScoped<ICreateExternalSubscriptionsCommand, CreateExternalSubscriptionsCommand>();
            services.AddTransient<ICreateExternalSubscriptionsCommand, CreateExternalSubscriptionsCommand>();

            services.AddScoped<IUpdateExternalSubscriptionsCommand, UpdateExternalSubscriptionsCommand>();
            services.AddTransient<IUpdateExternalSubscriptionsCommand, UpdateExternalSubscriptionsCommand>();

            services.AddScoped<IDeleteExternalSubscriptionsCommand, DeleteExternalSubscriptionsCommand>();
            services.AddTransient<IDeleteExternalSubscriptionsCommand, DeleteExternalSubscriptionsCommand>();

            services.AddScoped<IComposeExternalContentSubscriptionFeedCommand, ComposeExternalContentSubscriptionFeedCommand>();
            services.AddTransient<IComposeExternalContentSubscriptionFeedCommand, ComposeExternalContentSubscriptionFeedCommand>();

            return services;
        }
    }
}