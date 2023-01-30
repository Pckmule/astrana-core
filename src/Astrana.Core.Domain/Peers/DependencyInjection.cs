/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Peers.Commands.AcceptPeerConnectionRequests;
using Astrana.Core.Domain.Peers.Commands.CreatePeerConnectionRequests;
using Astrana.Core.Domain.Peers.Commands.RejectPeerConnectionRequests;
using Astrana.Core.Domain.Peers.Commands.SubmitPeerConnectionRequests;
using Astrana.Core.Domain.Peers.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Domain.Peers
{
    public static class DependencyInjection
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddScoped<ICreateReceivedPeerConnectionRequestsCommand, CreateReceivedPeerConnectionRequestsCommand>();
            services.AddTransient<ICreateReceivedPeerConnectionRequestsCommand, CreateReceivedPeerConnectionRequestsCommand>();

            services.AddScoped<IAcceptPeerConnectionRequestsCommand, AcceptPeerConnectionRequestsCommand>();
            services.AddTransient<IAcceptPeerConnectionRequestsCommand, AcceptPeerConnectionRequestsCommand>();

            services.AddScoped<IRejectPeerConnectionRequestsCommand, RejectPeerConnectionRequestsCommand>();
            services.AddTransient<IRejectPeerConnectionRequestsCommand, RejectPeerConnectionRequestsCommand>();

            services.AddScoped<ISubmitPeerConnectionRequestsCommand, SubmitPeerConnectionRequestsCommand>();
            services.AddTransient<ISubmitPeerConnectionRequestsCommand, SubmitPeerConnectionRequestsCommand>();

            services.AddScoped<IGetReceivedPeerConnectionRequestsQuery, GetReceivedPeerConnectionRequestsQuery>();
            services.AddTransient<IGetReceivedPeerConnectionRequestsQuery, GetReceivedPeerConnectionRequestsQuery>();

            services.AddScoped<IGetSubmittedPeerConnectionRequestsQuery, GetSubmittedPeerConnectionRequestsQuery>();
            services.AddTransient<IGetSubmittedPeerConnectionRequestsQuery, GetSubmittedPeerConnectionRequestsQuery>();

            services.AddScoped<IGetPeersQuery, GetPeersQuery>();
            services.AddTransient<IGetPeersQuery, GetPeersQuery>();

            services.AddScoped<IGetPeerProfileQuery, GetPeerProfileQuery>();
            services.AddTransient<IGetPeerProfileQuery, GetPeerProfileQuery>();

            return services;
        }
    }
}
