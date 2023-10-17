/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.AccessManagement;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Identity;
using Astrana.Core.Data.Entities.Peers;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Domain.Models.ContentCollections.Contracts;
using Astrana.Core.Domain.Models.ApiAccessTokens.Contracts;
using Astrana.Core.Domain.Models.Countries.Contracts;
using Astrana.Core.Domain.Models.Feelings.Contracts;
using Astrana.Core.Domain.Models.Images.Contracts;
using Astrana.Core.Domain.Models.Languages.Contracts;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.SystemSettings.Contracts;
using Astrana.Core.Domain.Models.Tags.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using Astrana.Core.Domain.Models.Videos.Contracts;
using AutoMapper;
using DomainModels = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data
{
    public class ModelMappings
    {
        public IConfigurationProvider Mappings { get; }

        public ModelMappings()
        {
            Mappings = new MapperConfiguration(cfg =>
            {
                // Mappings for Domain Models, Entities and Contracts

                // ### SystemSettings ###

                cfg.CreateMap<DomainModels.SystemSettings.SystemSetting, SystemSetting>();
                cfg.CreateMap<SystemSetting, DomainModels.SystemSettings.SystemSetting>();
                
                cfg.CreateMap<ISystemSetting, SystemSetting>();
                cfg.CreateMap<SystemSetting, ISystemSetting>();
                
                cfg.CreateMap<DomainModels.SystemSettings.SystemSetting, ISystemSetting>();
                cfg.CreateMap<ISystemSetting, DomainModels.SystemSettings.SystemSetting>();

                cfg.CreateMap<DomainModels.SystemSettings.SystemSettingCategory, SystemSettingCategory>();
                cfg.CreateMap<SystemSettingCategory, DomainModels.SystemSettings.SystemSettingCategory>();

                cfg.CreateMap<ISystemSettingCategory, SystemSettingCategory>();
                cfg.CreateMap<SystemSettingCategory, ISystemSettingCategory>();

                cfg.CreateMap<DomainModels.SystemSettings.SystemSettingCategory, ISystemSettingCategory>();
                cfg.CreateMap<ISystemSettingCategory, DomainModels.SystemSettings.SystemSettingCategory>();

                // ### Languages ###

                cfg.CreateMap<DomainModels.Languages.Language, Language>();
                cfg.CreateMap<Language, DomainModels.Languages.Language>();

                cfg.CreateMap<DomainModels.Languages.LanguageToAdd, Language>();
                cfg.CreateMap<Language, DomainModels.Languages.LanguageToAdd>();

                cfg.CreateMap<ILanguage, Language>();
                cfg.CreateMap<Language, ILanguage>();

                cfg.CreateMap<ILanguageToAdd, Language>();
                cfg.CreateMap<Language, ILanguageToAdd>();

                cfg.CreateMap<DomainModels.Languages.Language, ILanguage>();
                cfg.CreateMap<ILanguage, DomainModels.Languages.Language>();

                cfg.CreateMap<DomainModels.Languages.LanguageToAdd, ILanguageToAdd>();
                cfg.CreateMap<ILanguageToAdd, DomainModels.Languages.LanguageToAdd>();

                // ### Countries ###

                cfg.CreateMap<DomainModels.Countries.Country, Country>();
                cfg.CreateMap<Country, DomainModels.Countries.Country>();

                cfg.CreateMap<DomainModels.Countries.Country, ICountry>();
                cfg.CreateMap<ICountry, DomainModels.Countries.Country>();

                cfg.CreateMap<DomainModels.Countries.CountryToAdd, ICountryToAdd>();
                cfg.CreateMap<ICountryToAdd, DomainModels.Countries.CountryToAdd>();

                cfg.CreateMap<DomainModels.Countries.CountryToAdd, Country>();
                cfg.CreateMap<Country, DomainModels.Countries.CountryToAdd>();

                cfg.CreateMap<ICountry, DomainModels.Countries.Country>();
                cfg.CreateMap<DomainModels.Countries.Country, ICountry>();

                cfg.CreateMap<ICountryToAdd, DomainModels.Countries.Country>();
                cfg.CreateMap<DomainModels.Countries.Country, ICountryToAdd>();

                // ### Api Access Tokens ###

                cfg.CreateMap<DomainModels.ApiAccessTokens.ApiAccessToken, ApiAccessToken>();
                cfg.CreateMap<ApiAccessToken, DomainModels.ApiAccessTokens.ApiAccessToken>();

                cfg.CreateMap<DomainModels.ApiAccessTokens.ApiAccessToken, IApiAccessToken>();
                cfg.CreateMap<IApiAccessToken, DomainModels.ApiAccessTokens.ApiAccessToken>();

                cfg.CreateMap<DomainModels.ApiAccessTokens.ApiAccessTokenToAdd, IApiAccessTokenToAdd>();
                cfg.CreateMap<IApiAccessTokenToAdd, DomainModels.ApiAccessTokens.ApiAccessTokenToAdd>();

                cfg.CreateMap<IApiAccessToken, ApiAccessToken>();
                cfg.CreateMap<ApiAccessToken, IApiAccessToken>();

                cfg.CreateMap<IApiAccessTokenToAdd, ApiAccessToken>();
                cfg.CreateMap<ApiAccessToken, IApiAccessTokenToAdd>();

                // ### User Accounts ###

                cfg.CreateMap<DomainModels.UserAccounts.UserAccount, UserAccount>();
                cfg.CreateMap<UserAccount, DomainModels.UserAccounts.UserAccount>();

                cfg.CreateMap<DomainModels.UserAccounts.UserAccount, IUserAccount>();
                cfg.CreateMap<IUserAccount, DomainModels.UserAccounts.UserAccount>();

                cfg.CreateMap<DomainModels.UserAccounts.UserAccountToAdd, IUserAccountToAdd>();
                cfg.CreateMap<IUserAccountToAdd, DomainModels.UserAccounts.UserAccountToAdd>();

                cfg.CreateMap<IUserAccount, UserAccount>();
                cfg.CreateMap<UserAccount, IUserAccount>();

                cfg.CreateMap<IUserAccountToAdd, UserAccount>();
                cfg.CreateMap<UserAccount, IUserAccountToAdd>();

                // ### User Profiles ###

                cfg.CreateMap<DomainModels.UserProfiles.UserProfile, UserProfile>();
                cfg.CreateMap<UserProfile, DomainModels.UserProfiles.UserProfile>();

                cfg.CreateMap<DomainModels.UserProfiles.UserProfile, IUserProfile>();
                cfg.CreateMap<IUserProfile, DomainModels.UserProfiles.UserProfile>();

                cfg.CreateMap<DomainModels.UserProfiles.UserProfileToAdd, IUserProfileToAdd>();
                cfg.CreateMap<IUserProfileToAdd, DomainModels.UserProfiles.UserProfileToAdd>();

                cfg.CreateMap<IUserProfile, UserProfile>();
                cfg.CreateMap<UserProfile, IUserProfile>();

                cfg.CreateMap<IUserProfileToAdd, UserProfile>();
                cfg.CreateMap<UserProfile, IUserProfileToAdd>();

                // ### User Profile Details ###

                cfg.CreateMap<DomainModels.UserProfiles.UserProfileDetail, UserProfileDetail>();
                cfg.CreateMap<UserProfileDetail, DomainModels.UserProfiles.UserProfileDetail>();

                cfg.CreateMap<DomainModels.UserProfiles.UserProfileDetail, IUserProfileDetail>();
                cfg.CreateMap<IUserProfileDetail, DomainModels.UserProfiles.UserProfileDetail>();

                cfg.CreateMap<DomainModels.UserProfiles.UserProfileDetailToAdd, IUserProfileDetailToAdd>();
                cfg.CreateMap<IUserProfileDetailToAdd, DomainModels.UserProfiles.UserProfileDetailToAdd>();

                cfg.CreateMap<IUserProfileDetail, UserProfileDetail>();
                cfg.CreateMap<UserProfileDetail, IUserProfileDetail>();

                cfg.CreateMap<IUserProfileDetailToAdd, UserProfileDetail>();
                cfg.CreateMap<UserProfileDetail, IUserProfileDetailToAdd>();

                // ### Images ###

                cfg.CreateMap<DomainModels.Images.Image, Image>();
                cfg.CreateMap<Image, DomainModels.Images.Image>();

                cfg.CreateMap<DomainModels.Images.Image, IImage>();
                cfg.CreateMap<IImage, DomainModels.Images.Image>();

                cfg.CreateMap<DomainModels.Images.ImageToAdd, IImageToAdd>();
                cfg.CreateMap<IImageToAdd, DomainModels.Images.ImageToAdd>();

                cfg.CreateMap<IImage, Image>();
                cfg.CreateMap<Image, IImage>();

                cfg.CreateMap<IImageToAdd, Image>();
                cfg.CreateMap<Image, IImageToAdd>();

                cfg.CreateMap<DomainModels.Images.ImageToAdd, Image>();
                cfg.CreateMap<Image, DomainModels.Images.ImageToAdd>();

                // ### Videos ###

                cfg.CreateMap<DomainModels.Videos.Video, Video>();
                cfg.CreateMap<Video, DomainModels.Videos.Video>();

                cfg.CreateMap<DomainModels.Videos.Video, IVideo>();
                cfg.CreateMap<IVideo, DomainModels.Videos.Video>();

                cfg.CreateMap<DomainModels.Videos.VideoToAdd, IVideoToAdd>();
                cfg.CreateMap<IVideoToAdd, DomainModels.Videos.VideoToAdd>();

                cfg.CreateMap<IVideo, Video>();
                cfg.CreateMap<Video, IVideo>();

                cfg.CreateMap<IVideoToAdd, Video>();
                cfg.CreateMap<Video, IVideoToAdd>();

                cfg.CreateMap<DomainModels.Videos.VideoToAdd, Video>();
                cfg.CreateMap<Video, DomainModels.Videos.VideoToAdd>();

                // ### Peers ###

                cfg.CreateMap<DomainModels.Peers.Peer, Peer>();
                cfg.CreateMap<Peer, DomainModels.Peers.Peer>();

                cfg.CreateMap<IPeer, Peer>();
                cfg.CreateMap<Peer, IPeer>();

                cfg.CreateMap<IPeerToAdd, Peer>();
                cfg.CreateMap<Peer, IPeerToAdd>();

                cfg.CreateMap<IPeer, DomainModels.Peers.Peer>();
                cfg.CreateMap<DomainModels.Peers.Peer, IPeer>();

                cfg.CreateMap<IPeerToAdd, DomainModels.Peers.PeerToAdd>();
                cfg.CreateMap<DomainModels.Peers.PeerToAdd, IPeerToAdd>();

                // ### Peer Connection Request Received ###

                cfg.CreateMap<DomainModels.Peers.PeerConnectionRequestReceived, PeerConnectionRequestReceived>();
                cfg.CreateMap<PeerConnectionRequestReceived, DomainModels.Peers.PeerConnectionRequestReceived>();

                cfg.CreateMap<IPeerConnectionRequestReceived, PeerConnectionRequestReceived>();
                cfg.CreateMap<PeerConnectionRequestReceived, IPeerConnectionRequestReceived>();

                cfg.CreateMap<IPeerConnectionRequestReceivedToAdd, PeerConnectionRequestReceived>();
                cfg.CreateMap<PeerConnectionRequestReceived, IPeerConnectionRequestReceivedToAdd>();

                cfg.CreateMap<IPeerConnectionRequestReceived, DomainModels.Peers.PeerConnectionRequestReceived>();
                cfg.CreateMap<DomainModels.Peers.PeerConnectionRequestReceived, IPeerConnectionRequestReceived>();

                cfg.CreateMap<IPeerConnectionRequestReceivedToAdd, DomainModels.Peers.PeerConnectionRequestReceivedToAdd>();
                cfg.CreateMap<DomainModels.Peers.PeerConnectionRequestReceivedToAdd, IPeerConnectionRequestReceivedToAdd>();

                // ### Peer Connection Request Submitted ###

                cfg.CreateMap<DomainModels.Peers.PeerConnectionRequestSubmitted, PeerConnectionRequestSubmitted>();
                cfg.CreateMap<PeerConnectionRequestSubmitted, DomainModels.Peers.PeerConnectionRequestSubmitted>();

                cfg.CreateMap<IPeerConnectionRequestSubmitted, PeerConnectionRequestSubmitted>();
                cfg.CreateMap<PeerConnectionRequestSubmitted, IPeerConnectionRequestSubmitted>();

                cfg.CreateMap<IPeerConnectionRequestSubmittedToAdd, PeerConnectionRequestSubmitted>();
                cfg.CreateMap<PeerConnectionRequestSubmitted, IPeerConnectionRequestSubmittedToAdd>();

                cfg.CreateMap<IPeerConnectionRequestSubmitted, DomainModels.Peers.PeerConnectionRequestSubmitted>();
                cfg.CreateMap<DomainModels.Peers.PeerConnectionRequestSubmitted, IPeerConnectionRequestSubmitted>();

                cfg.CreateMap<IPeerConnectionRequestSubmittedToAdd, DomainModels.Peers.PeerConnectionRequestSubmittedToAdd>();
                cfg.CreateMap<DomainModels.Peers.PeerConnectionRequestSubmittedToAdd, IPeerConnectionRequestSubmittedToAdd>();

                // ### Tags ###

                cfg.CreateMap<DomainModels.Tags.Tag, Tag>();
                cfg.CreateMap<Tag, DomainModels.Tags.Tag>();

                cfg.CreateMap<ITag, DomainModels.Tags.Tag>();
                cfg.CreateMap<DomainModels.Tags.Tag, ITag>();

                cfg.CreateMap<ITagToAdd, DomainModels.Tags.TagToAdd>();
                cfg.CreateMap<DomainModels.Tags.TagToAdd, ITagToAdd>();

                cfg.CreateMap<ITag, Tag>();
                cfg.CreateMap<Tag, ITag>();

                cfg.CreateMap<ITagToAdd, Tag>();
                cfg.CreateMap<Tag, ITagToAdd>();

                // ### Posts ###

                cfg.CreateMap<DomainModels.Posts.Post, Post>();
                cfg.CreateMap<Post, DomainModels.Posts.Post>();

                cfg.CreateMap<IPost, DomainModels.Posts.Post>();
                cfg.CreateMap<DomainModels.Posts.Post, IPost>();

                //cfg.CreateMap<IPostToAdd, DomainModels.Posts.PostToAdd>();
                //cfg.CreateMap<DomainModels.Posts.PostToAdd, IPostToAdd>();

                //cfg.CreateMap<IPost, Post>();
                //cfg.CreateMap<Post, IPost>();

                //cfg.CreateMap<IPostToAdd, Post>();
                //cfg.CreateMap<Post, IPostToAdd>();

                //cfg.CreateMap<DomainModels.Posts.PostToAdd, Post>();
                //cfg.CreateMap<Post, DomainModels.Posts.PostToAdd>();

                // ### Post Attachments ###

                cfg.CreateMap<DomainModels.Posts.PostAttachment, PostAttachment>();
                cfg.CreateMap<PostAttachment, DomainModels.Posts.PostAttachment>();

                cfg.CreateMap<DomainModels.Posts.PostAttachmentToAdd, PostAttachment>();
                cfg.CreateMap<PostAttachment, DomainModels.Posts.PostAttachmentToAdd>();

                cfg.CreateMap<IPostAttachment, PostAttachment>();
                cfg.CreateMap<PostAttachment, IPostAttachment>();

                cfg.CreateMap<IPostAttachmentToAdd, PostAttachment>();
                cfg.CreateMap<PostAttachment, IPostAttachmentToAdd>();

                cfg.CreateMap<DomainModels.Posts.PostAttachment, IPostAttachment>();
                cfg.CreateMap<IPostAttachment, DomainModels.Posts.PostAttachment>();

                cfg.CreateMap<DomainModels.Posts.PostAttachmentToAdd, IPostAttachmentToAdd>();
                cfg.CreateMap<IPostAttachmentToAdd, DomainModels.Posts.PostAttachmentToAdd>();

                cfg.CreateMap<DomainModels.Posts.PostAttachment, DomainModels.Posts.PostAttachmentToAdd>();
                cfg.CreateMap<DomainModels.Posts.PostAttachmentToAdd, DomainModels.Posts.PostAttachment>();

                // ### Links ###

                cfg.CreateMap<DomainModels.Links.Link, Link>();
                cfg.CreateMap<Link, DomainModels.Links.Link>();

                cfg.CreateMap<DomainModels.Links.Link, ILink>();
                cfg.CreateMap<ILink, DomainModels.Links.Link>();

                cfg.CreateMap<DomainModels.Links.LinkToAdd, ILinkToAdd>();
                cfg.CreateMap<ILinkToAdd, DomainModels.Links.LinkToAdd>();

                cfg.CreateMap<ILink, Link>();
                cfg.CreateMap<Link, ILink>();

                cfg.CreateMap<ILinkToAdd, Link>();
                cfg.CreateMap<Link, ILinkToAdd>();

                // ### Feelings ###

                cfg.CreateMap<DomainModels.Feelings.Feeling, Feeling>();
                cfg.CreateMap<Feeling, DomainModels.Feelings.Feeling>();

                cfg.CreateMap<DomainModels.Feelings.Feeling, IFeeling>();
                cfg.CreateMap<IFeeling, DomainModels.Feelings.Feeling>();

                cfg.CreateMap<DomainModels.Feelings.FeelingToAdd, IFeelingToAdd>();
                cfg.CreateMap<IFeelingToAdd, DomainModels.Feelings.FeelingToAdd>();

                cfg.CreateMap<IFeeling, Feeling>();
                cfg.CreateMap<Feeling, IFeeling>();

                cfg.CreateMap<IFeelingToAdd, Feeling>();
                cfg.CreateMap<Feeling, IFeelingToAdd>();

                cfg.CreateMap<DomainModels.Feelings.FeelingToAdd, Feeling>();
                cfg.CreateMap<Feeling, DomainModels.Feelings.FeelingToAdd>();

                // ### ContentCollections ###

                cfg.CreateMap<DomainModels.ContentCollections.ContentCollection, ContentCollection>();
                cfg.CreateMap<ContentCollection, DomainModels.ContentCollections.ContentCollection>();

                cfg.CreateMap<DomainModels.ContentCollections.ContentCollection, IContentCollection>();
                cfg.CreateMap<IContentCollection, DomainModels.ContentCollections.ContentCollection>();

                //cfg.CreateMap<DomainModels.ContentCollections.ContentCollectionToAdd, IContentCollectionToAdd>();
                //cfg.CreateMap<IContentCollectionToAdd, DomainModels.ContentCollections.ContentCollectionToAdd>();

                cfg.CreateMap<IContentCollection, ContentCollection>();
                cfg.CreateMap<ContentCollection, IContentCollection>();

                //cfg.CreateMap<IContentCollectionToAdd, ContentCollection>();
                //cfg.CreateMap<ContentCollection, IContentCollectionToAdd>();
            });
        }
    }
}
