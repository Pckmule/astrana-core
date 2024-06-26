﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ContentCollections.Commands.CreateContentCollections;
using Astrana.Core.Domain.ContentCollections.Commands.DeleteContentCollections;
using Astrana.Core.Domain.ContentCollections.Commands.UpdateContentCollections;
using Astrana.Core.Domain.ContentCollections.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.ContentCollections
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetContentCollectionsQuery, GetContentCollectionsQuery>();
            services.AddTransient<IGetContentCollectionsQuery, GetContentCollectionsQuery>();

            services.AddScoped<ICreateContentCollectionsCommand, CreateContentCollectionsCommand>();
            services.AddTransient<ICreateContentCollectionsCommand, CreateContentCollectionsCommand>();

            services.AddScoped<IUpdateContentCollectionsCommand, UpdateContentCollectionsCommand>();
            services.AddTransient<IUpdateContentCollectionsCommand, UpdateContentCollectionsCommand>();

            services.AddScoped<IDeleteContentCollectionsCommand, DeleteContentCollectionsCommand>();
            services.AddTransient<IDeleteContentCollectionsCommand, DeleteContentCollectionsCommand>();

            return services;
        }
    }
}
