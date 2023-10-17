/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.NewContentWorkflowStages.Commands.CreateNewContentWorkflowStages;
using Astrana.Core.Domain.NewContentWorkflowStages.Commands.DeleteNewContentWorkflowStages;
using Astrana.Core.Domain.NewContentWorkflowStages.Commands.UpdateNewContentWorkflowStages;
using Astrana.Core.Domain.NewContentWorkflowStages.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.NewContentWorkflowStages
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<IGetNewContentWorkflowStagesQuery, GetNewContentWorkflowStagesQuery>();
            services.AddTransient<IGetNewContentWorkflowStagesQuery, GetNewContentWorkflowStagesQuery>();

            services.AddScoped<ICreateNewContentWorkflowStagesCommand, CreateNewContentWorkflowStagesCommand>();
            services.AddTransient<ICreateNewContentWorkflowStagesCommand, CreateNewContentWorkflowStagesCommand>();

            services.AddScoped<IUpdateNewContentWorkflowStagesCommand, UpdateNewContentWorkflowStagesCommand>();
            services.AddTransient<IUpdateNewContentWorkflowStagesCommand, UpdateNewContentWorkflowStagesCommand>();

            services.AddScoped<IDeleteNewContentWorkflowStagesCommand, DeleteNewContentWorkflowStagesCommand>();
            services.AddTransient<IDeleteNewContentWorkflowStagesCommand, DeleteNewContentWorkflowStagesCommand>();
            
            return services;
        }
    }
}