/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Videos.Commands.SaveRemoteVideo;
using Astrana.Core.Domain.Videos.Commands.UploadVideo;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Videos
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IUploadVideoCommand, UploadVideoCommand>();
            services.AddTransient<IUploadVideoCommand, UploadVideoCommand>();

            services.AddScoped<ISaveRemoteVideoCommand, SaveRemoteVideoCommand>();
            services.AddTransient<ISaveRemoteVideoCommand, SaveRemoteVideoCommand>();

            return services;
        }
    }
}
