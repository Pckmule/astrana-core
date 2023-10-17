/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Links.Commands.CreateLinks;
using Astrana.Core.Domain.Links.Commands.DeleteLinks;
using Astrana.Core.Domain.Links.Commands.UpdateLinks;
using Astrana.Core.Domain.Links.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Links
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetLinksQuery, GetLinksQuery>();
            services.AddTransient<IGetLinksQuery, GetLinksQuery>();

            services.AddScoped<ICreateLinksCommand, CreateLinksCommand>();
            services.AddTransient<ICreateLinksCommand, CreateLinksCommand>();

            services.AddScoped<IUpdateLinksCommand, UpdateLinksCommand>();
            services.AddTransient<IUpdateLinksCommand, UpdateLinksCommand>();

            services.AddScoped<IDeleteLinksCommand, DeleteLinksCommand>();
            services.AddTransient<IDeleteLinksCommand, DeleteLinksCommand>();

            services.AddScoped<IGetLinkSummaryQuery, GetLinkSummaryQuery>();
            services.AddTransient<IGetLinkSummaryQuery, GetLinkSummaryQuery>();

            return services;
        }
    }
}