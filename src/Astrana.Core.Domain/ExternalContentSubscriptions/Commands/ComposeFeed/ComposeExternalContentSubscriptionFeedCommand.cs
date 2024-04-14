/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ExternalContentSubscriptions;
using Astrana.Core.Domain.ExternalFeeds.Queries;
using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Models.AstranaApi;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Options;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Commands.ComposeFeed
{
    public class ComposeExternalContentSubscriptionFeedCommand : IComposeExternalContentSubscriptionFeedCommand
    {
        private readonly ILogger<ComposeExternalContentSubscriptionFeedCommand> _logger;

        private readonly IExternalContentSubscriptionRepository<Guid> _externalContentSubscriptionRepository;
        private readonly IFetchExternalFeedItemsQuery _fetchExternalFeedItemsQuery;
        private readonly IAstranaApiInfo _astranaApiInfo;

        public ComposeExternalContentSubscriptionFeedCommand(
            ILogger<ComposeExternalContentSubscriptionFeedCommand> logger, 
            IExternalContentSubscriptionRepository<Guid> externalContentSubscriptionRepository,
            IFetchExternalFeedItemsQuery fetchExternalFeedItemsQuery,
            IAstranaApiInfo astranaApiInfo)
        {
            _logger = logger;

            _externalContentSubscriptionRepository = externalContentSubscriptionRepository;
            _fetchExternalFeedItemsQuery = fetchExternalFeedItemsQuery;
            _astranaApiInfo = astranaApiInfo;
        }

        public async Task<GetResult<MainFeedQueryOptions<Guid, Guid>, StandardFeedItem, Guid, Guid>> ExecuteAsync(MainFeedQueryOptions<Guid, Guid> options, Guid actioningUserId)
        {
            var subscriptionsWithItems = await FindExternalContentSubscriptionsWithItemsAsync(options);
            var subscriptionData = FetchExternalContentSubscriptionItems(subscriptionsWithItems, options, actioningUserId);

            var feedItems = new List<StandardFeedItem>();

            foreach (var data in subscriptionData)
            {
                feedItems.AddRange(data.Value.ContentItems);
            }

            feedItems = feedItems.OrderByDescending(o => o.LastUpdated).ToList();

            foreach (var feedItem in feedItems)
            {
                if (feedItem.Image?.Location != null && feedItem.Image.Location.StartsWith('/'))
                {
                    feedItem.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, feedItem.Image.Location);
                }

                if (feedItem.Thumbnail?.Location != null && feedItem.Thumbnail.Location.StartsWith('/'))
                {
                    feedItem.Thumbnail.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, feedItem.Thumbnail.Location);
                }
            }

            return new GetResult<MainFeedQueryOptions<Guid, Guid>, StandardFeedItem, Guid, Guid>(feedItems, options, feedItems.Count);
        }

        /// <summary>
        /// Returns External Subscription Content Item data for the Content Items that are available from the specified External Content Subscription, that match the query options specified.
        /// </summary>
        /// <param name="externalContentSubscriptions"></param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        private Dictionary<string, SubscriptionItemsModel> FetchExternalContentSubscriptionItems(List<ExternalContentSubscription> externalContentSubscriptions, MainFeedQueryOptions<Guid, Guid> queryOptions, Guid actioningUserId)
        {
            var subscriptionItemsCalls = new Dictionary<string, Task>();
            var subscriptionItems = new Dictionary<string, SubscriptionItemsModel>();

            foreach (var subscription in externalContentSubscriptions)
            {
                subscriptionItemsCalls[subscription.Id.ToString()] = Task.Run(async () =>
                {
                    var httpClient = new HttpClient();

                    if (!string.IsNullOrWhiteSpace(subscription.AccessToken))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.Api.AuthorizationSchemeName.Bearer, subscription.AccessToken);

                    var items = (await _fetchExternalFeedItemsQuery.ExecuteAsync(subscription.Url, actioningUserId, new FeedSource(subscription.Url, subscription.Title, subscription.IconImage?.Location))).Data;

                    subscriptionItems[subscription.Id.ToString()] = new SubscriptionItemsModel(subscription.Url, subscription, items);
                });
            }

            Task.WhenAll(subscriptionItemsCalls.Select(o => o.Value).ToArray()).Wait();

            return subscriptionItems;
        }

        /// <summary>
        ///  Returns metadata about the External Content Subscription Items that are available from the specified External Content Subscription, that match the query options specified.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private async Task<List<ExternalContentSubscription>> FindExternalContentSubscriptionsWithItemsAsync(MainFeedQueryOptions<Guid, Guid> options)
        {
            var externalContentSubscriptions = await _externalContentSubscriptionRepository.GetExternalContentSubscriptionsAsync(new ExternalContentSubscriptionQueryOptions<Guid, Guid> { PageSize = int.MaxValue });

            var subscriptionItemsDiscoveryCalls = new Dictionary<string, Task>();
            var subscriptionItemsDiscoveryResponses = new Dictionary<string, ApiCallerResult>();

            foreach (var subscription in externalContentSubscriptions.Data)
            {
                if (subscription.IconImage?.Location != null && subscription.IconImage.Location.StartsWith('/'))
                {
                    subscription.IconImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, subscription.IconImage.Location);
                }

                if (subscription.LogoImage?.Location != null && subscription.LogoImage.Location.StartsWith('/'))
                {
                    subscription.LogoImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, subscription.LogoImage.Location);
                }

                if (subscription.CoverImage?.Location != null && subscription.CoverImage.Location.StartsWith('/'))
                {
                    subscription.CoverImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, subscription.CoverImage.Location);
                }

                subscriptionItemsDiscoveryCalls[subscription.Id.ToString()] = Task.Run(async () =>
                {
                    var httpClient = new HttpClient();

                    if (!string.IsNullOrWhiteSpace(subscription.AccessToken))
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.Api.AuthorizationSchemeName.Bearer, subscription.AccessToken);

                    subscriptionItemsDiscoveryResponses[subscription.Id.ToString()] = new ApiCallerResult(await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, subscription.Url.ToString())));

                    return subscriptionItemsDiscoveryResponses;
                });
            }

            Task.WhenAll(subscriptionItemsDiscoveryCalls.Select(o => o.Value).ToArray()).Wait();

            return externalContentSubscriptions.Data;
        }
    }

    internal sealed class SubscriptionItemsModel
    {
        public SubscriptionItemsModel(Uri address, ExternalContentSubscription subscriptionSummary, List<StandardFeedItem>? subscriptionItems = null)
        {
            Address = address;
            SubscriptionSummary = subscriptionSummary;
            ContentItems = subscriptionItems ?? new List<StandardFeedItem>();
        }

        public Uri Address { get; }

        public ExternalContentSubscription SubscriptionSummary { get; }

        public IReadOnlyCollection<StandardFeedItem> ContentItems { get; }
    }
}
