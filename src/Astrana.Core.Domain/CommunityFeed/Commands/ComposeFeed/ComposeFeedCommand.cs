/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.AstranaLink.Builders;
using Astrana.Core.Domain.AstranaLink.Enums;
using Astrana.Core.Domain.MainFeed.Commands.ComposeFeed;
using Astrana.Core.Domain.Models.AstranaApi;
using Astrana.Core.Domain.Models.MainFeed;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Domain.Models.UserProfiles.Extensions;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.CommunityFeed.Commands.ComposeFeed
{
    public class ComposeFeedCommand : IComposeFeedCommand
    {
        private readonly ILogger<ComposeFeedCommand> _logger;
        private readonly IPeerRepository<Guid> _peerRepository;

        public ComposeFeedCommand(ILogger<ComposeFeedCommand> logger, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _peerRepository = peerRepository;
        }

        public async Task<GetResult<MainFeedQueryOptions<Guid, Guid>, FeedContentItem, Guid, Guid>> ExecuteAsync(MainFeedQueryOptions<Guid, Guid> options, Guid actioningUserId)
        {
            // TODO: RefreshExpiredPeerApiAccessTokens();

            var peersWithPosts = await FindPeersWithPostsAsync(options);
            var peersPosts = FetchPeerPosts(peersWithPosts, options);
            var peerProfileData = FetchPeerProfileDataAsync(peersWithPosts);

            var peerData = peerProfileData.Select(data => new PeerPostsModel(peersWithPosts.First(p => p.PeerId == data.UserAccountId).Address, data, peersPosts.FirstOrDefault(p => p.Key == data.UserAccountId.ToString()).Value.GetContent().Data)).ToList();

            var feedItems = new List<FeedContentItem>();

            foreach (var data in peerData)
            {
                feedItems.AddRange(data.Posts.Select(p => new FeedContentItem
                {
                    PeerUuid = data.Profile.UserAccountId.ToString(),
                    PeerName = data.Profile.GetNameCombination(NameCombination.FirstLast),
                    PeerPictureUrl = "", //data.Profile.ProfilePicture?.Location ?? "", // TODO: Fix
                    ProfileUrl = AstranaLinkBuilder.Build(data.Address, AstranaPage.Profile),
                    Text = p.Text,
                    CreatedTimestamp = p.CreatedTimestamp
                }));
            }

            feedItems = feedItems.OrderByDescending(o => o.CreatedTimestamp).ToList();

            return new GetResult<MainFeedQueryOptions<Guid, Guid>, FeedContentItem, Guid, Guid>(feedItems, options, feedItems.Count);
        }

        /// <summary>
        /// Returns Post data for the Posts that are available from the specified peer Astrana instances, that match the query options specified.
        /// </summary>
        /// <param name="peers"></param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        private static Dictionary<string, ApiCallerResult<List<Post>>> FetchPeerPosts(List<Peer> peers, MainFeedQueryOptions<Guid, Guid> queryOptions)
        {
            var peerPostsCalls = new Dictionary<string, Task>();
            var peersPosts = new Dictionary<string, ApiCallerResult<List<Post>>>();

            foreach (var peer in peers)
            {
                peerPostsCalls[peer.PeerId.ToString()] = Task.Run(async () =>
                {
                    var apiCaller = new AstranaApiClient();

                    apiCaller.SetAuthorizationToken(peer.PeerAccessToken);

                    peersPosts[peer.PeerId.ToString()] = await apiCaller.GetAsync<List<Post>>(peer.Address, "posts", "", queryOptions.ToQueryStringList());
                });
            }

            Task.WhenAll(peerPostsCalls.Select(o => o.Value).ToArray()).Wait();

            return peersPosts;
        }

        /// <summary>
        ///  Returns metadata about the Posts that are available from the specified peer Astrana instances, that match the query options specified.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private async Task<List<Peer>> FindPeersWithPostsAsync(MainFeedQueryOptions<Guid, Guid> options)
        {
            var peers = await _peerRepository.GetPeersAsync(new PeerQueryOptions<Guid, Guid> { PageSize = int.MaxValue });

            var peerPostsDiscoveryCalls = new Dictionary<string, Task>();
            var peersPostsDiscoveryResponses = new Dictionary<string, ApiCallerResult>();

            foreach (var peer in peers.Data)
            {
                peerPostsDiscoveryCalls[peer.PeerId.ToString()] = Task.Run(async () =>
                {
                    var apiCaller = new AstranaApiClient();

                    apiCaller.SetAuthorizationToken(peer.PeerAccessToken);

                    peersPostsDiscoveryResponses[peer.PeerId.ToString()] = await apiCaller.HeadAsync(peer.Address, "posts", "discover", options.ToQueryStringList());

                    return peersPostsDiscoveryResponses;
                });
            }

            Task.WhenAll(peerPostsDiscoveryCalls.Select(o => o.Value).ToArray()).Wait();

            return peers.Data.Where(p => peersPostsDiscoveryResponses.Where(m => m.Value.Content.CustomHeaders.ContainsKey(Constants.Api.HeaderNames.Astrana.TotalCount) && int.TryParse(m.Value.Content.CustomHeaders[Constants.Api.HeaderNames.Astrana.TotalCount], out var totalCount) && totalCount > 0).Any(o => o.Key == p.PeerId.ToString())).ToList();
        }

        private List<UserProfile> FetchPeerProfileDataAsync(List<Peer> peers)
        {
            var peerProfileCalls = new Dictionary<string, Task>();
            var peerProfiles = new Dictionary<string, ApiCallerResult<UserProfile>>();

            foreach (var peer in peers)
            {
                peerProfileCalls[peer.PeerId.ToString()] = Task.Run(async () =>
                {
                    var apiCaller = new AstranaApiClient();

                    apiCaller.SetAuthorizationToken(peer.PeerAccessToken);

                    peerProfiles[peer.PeerId.ToString()] = await apiCaller.GetAsync<UserProfile>(peer.Address, "user", "profile");
                });
            }

            Task.WhenAll(peerProfileCalls.Select(o => o.Value).ToArray()).Wait();

            return peerProfiles.Select(o => o.Value.GetContent().Data).ToList()!;
        }

        /// <summary>
        ///  Refreshes expired and almost expired Astrana instance API access tokens for the specified Astrana instances.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private async Task<List<Peer>> RefreshExpiredPeerApiAccessTokens(MainFeedQueryOptions<Guid, Guid> options)
        {
            var peers = await _peerRepository.GetPeersAsync(new PeerQueryOptions<Guid, Guid> { PageSize = int.MaxValue });

            var peerRefreshTokenCalls = new Dictionary<string, Task>();
            var peersRefreshTokenResponses = new Dictionary<string, ApiCallerResult>();

            foreach (var peer in peers.Data)
            {
                peerRefreshTokenCalls[peer.PeerId.ToString()] = Task.Run(async () =>
                {
                    var apiCaller = new AstranaApiClient();

                    apiCaller.SetAuthorizationToken(peer.PeerAccessToken);

                    peersRefreshTokenResponses[peer.PeerId.ToString()] = await apiCaller.HeadAsync(peer.Address, "peers", "access/refresh", options.ToQueryStringList());

                    return peersRefreshTokenResponses;
                });
            }

            Task.WhenAll(peerRefreshTokenCalls.Select(o => o.Value).ToArray()).Wait();

            return peers.Data.Where(p => peersRefreshTokenResponses.Where(m => m.Value.Content.CustomHeaders.ContainsKey(Constants.Api.HeaderNames.Astrana.TotalCount) && int.TryParse(m.Value.Content.CustomHeaders[Constants.Api.HeaderNames.Astrana.TotalCount], out var totalCount) && totalCount > 0).Any(o => o.Key == p.PeerId.ToString())).ToList();
        }
    }
    
    internal sealed class PeerPostsModel
    {
        public PeerPostsModel(string address, UserProfile profile, List<Post>? posts = null)
        {
            Address = address;
            Profile = profile ?? throw new ArgumentNullException(nameof(profile));
            Posts = posts ?? new List<Post>();
        }

        public string Address { get; }

        public UserProfile Profile { get; }

        public IReadOnlyCollection<Post> Posts { get; }
    }

}
