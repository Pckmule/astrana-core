/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Files.Commands.GetFileStream;
using Astrana.Core.Domain.Files.Commands.SaveRemoteFile;
using Astrana.Core.Domain.Files.Commands.UploadFile;
using Astrana.Core.Domain.Files.Queries.GetFileInfo;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Files
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetFileStreamCommand, GetFileStreamCommand>();
            services.AddTransient<IGetFileStreamCommand, GetFileStreamCommand>();

            services.AddScoped<IUploadFileCommand, UploadFileCommand>();
            services.AddTransient<IUploadFileCommand, UploadFileCommand>();

            services.AddScoped<ISaveRemoteFileCommand, SaveRemoteFileCommand>();
            services.AddTransient<ISaveRemoteFileCommand, SaveRemoteFileCommand>();

            services.AddScoped<IGetFileInfoQuery, GetFileInfoQuery>();
            services.AddTransient<IGetFileInfoQuery, GetFileInfoQuery>();

            return services;
        }
    }
}
