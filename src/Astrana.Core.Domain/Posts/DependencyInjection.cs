/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Posts.Commands.CreatePosts;
using Astrana.Core.Domain.Posts.Commands.DeletePosts;
using Astrana.Core.Domain.Posts.Commands.UpdatePosts;
using Astrana.Core.Domain.Posts.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Posts
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetPostsQuery, GetPostsQuery>();
            services.AddTransient<IGetPostsQuery, GetPostsQuery>();

            services.AddScoped<ICreatePostsCommand, CreatePostsCommand>();
            services.AddTransient<ICreatePostsCommand, CreatePostsCommand>();

            services.AddScoped<IUpdatePostsCommand, UpdatePostsCommand>();
            services.AddTransient<IUpdatePostsCommand, UpdatePostsCommand>();

            services.AddScoped<IDeletePostsCommand, DeletePostsCommand>();
            services.AddTransient<IDeletePostsCommand, DeletePostsCommand>();

            services.AddScoped<IDiscoverPostsQuery, DiscoverPostsQuery>();
            services.AddTransient<IDiscoverPostsQuery, DiscoverPostsQuery>();

            return services;
        }
    }
}
