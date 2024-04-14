/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Notifications.Commands.Handlers.CreateNotifications;
using Astrana.Core.Domain.Notifications.Commands.Handlers.UpdateNotifications;
using Astrana.Core.Domain.Notifications.Queries;
using Astrana.Core.Domain.Notifications.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Notifications
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<INotificationRepository<Guid>, NotificationRepository>();
            services.AddTransient<INotificationRepository<Guid>, NotificationRepository>();

            services.AddScoped<IGetNotificationsQuery, GetNotificationsQuery>();
            services.AddTransient<IGetNotificationsQuery, GetNotificationsQuery>();

            services.AddScoped<ICreateNotificationsCommandHandler, CreateNotificationsCommandHandler>();
            services.AddTransient<ICreateNotificationsCommandHandler, CreateNotificationsCommandHandler>();

            services.AddScoped<IUpdateNotificationsCommandHandler, UpdateNotificationsCommandHandler>();
            services.AddTransient<IUpdateNotificationsCommandHandler, UpdateNotificationsCommandHandler>();

            return services;
        }
    }
}
