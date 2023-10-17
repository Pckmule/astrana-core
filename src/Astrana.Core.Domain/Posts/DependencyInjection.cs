/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Posts.Commands.Handlers.CreatePosts;
using Astrana.Core.Domain.Posts.Commands.Handlers.DeletePosts;
using Astrana.Core.Domain.Posts.Commands.Handlers.UpdatePosts;
using Astrana.Core.Domain.Posts.Queries;
using Astrana.Core.Domain.Posts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Posts
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository<Guid>, PostRepository>();
            services.AddTransient<IPostRepository<Guid>, PostRepository>();

            services.AddScoped<IGetPostsQuery, GetPostsQuery>();
            services.AddTransient<IGetPostsQuery, GetPostsQuery>();

            services.AddScoped<ICreatePostsCommandHandler, CreatePostsCommandHandler>();
            services.AddTransient<ICreatePostsCommandHandler, CreatePostsCommandHandler>();

            services.AddScoped<IUpdatePostsCommandHandler, UpdatePostsCommandHandler>();
            services.AddTransient<IUpdatePostsCommandHandler, UpdatePostsCommandHandler>();

            services.AddScoped<IDeletePostsCommandHandler, DeletePostsCommandHandler>();
            services.AddTransient<IDeletePostsCommandHandler, DeletePostsCommandHandler>();

            services.AddScoped<IDiscoverPostsQuery, DiscoverPostsQuery>();
            services.AddTransient<IDiscoverPostsQuery, DiscoverPostsQuery>();

            return services;
        }
    }
}
