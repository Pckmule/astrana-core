/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Albums.Commands.CreateAlbums;
using Astrana.Core.Domain.Albums.Commands.DeleteAlbums;
using Astrana.Core.Domain.Albums.Commands.UpdateAlbums;
using Astrana.Core.Domain.Albums.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Albums
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetAlbumsQuery, GetAlbumsQuery>();
            services.AddTransient<IGetAlbumsQuery, GetAlbumsQuery>();

            services.AddScoped<ICreateAlbumsCommand, CreateAlbumsCommand>();
            services.AddTransient<ICreateAlbumsCommand, CreateAlbumsCommand>();

            services.AddScoped<IUpdateAlbumsCommand, UpdateAlbumsCommand>();
            services.AddTransient<IUpdateAlbumsCommand, UpdateAlbumsCommand>();

            services.AddScoped<IDeleteAlbumsCommand, DeleteAlbumsCommand>();
            services.AddTransient<IDeleteAlbumsCommand, DeleteAlbumsCommand>();

            return services;
        }
    }
}
