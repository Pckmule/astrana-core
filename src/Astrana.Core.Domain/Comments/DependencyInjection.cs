/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Comments.Commands.CreateComments;
using Astrana.Core.Domain.Comments.Commands.DeleteComments;
using Astrana.Core.Domain.Comments.Commands.UpdateComments;
using Astrana.Core.Domain.Comments.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Comments
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetCommentsQuery, GetCommentsQuery>();
            services.AddTransient<IGetCommentsQuery, GetCommentsQuery>();

            services.AddScoped<ICreateCommentsCommand, CreateCommentsCommand>();
            services.AddTransient<ICreateCommentsCommand, CreateCommentsCommand>();

            services.AddScoped<IUpdateCommentsCommand, UpdateCommentsCommand>();
            services.AddTransient<IUpdateCommentsCommand, UpdateCommentsCommand>();

            services.AddScoped<IDeleteCommentsCommand, DeleteCommentsCommand>();
            services.AddTransient<IDeleteCommentsCommand, DeleteCommentsCommand>();

            return services;
        }
    }
}