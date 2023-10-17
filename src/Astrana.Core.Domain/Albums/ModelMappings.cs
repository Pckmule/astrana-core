using Astrana.Core.Domain.Models.ContentCollections.Enums;

namespace Astrana.Core.Domain.Albums
{
    public static class ModelMappings
    {
        public static Models.ContentCollections.ContentCollection ToContentCollection(Models.Albums.Album albumModel)
        {
            var model = new Models.ContentCollections.ContentCollection
            {
                ContentCollectionId = albumModel.AlbumId,

                Name = albumModel.Name,
                CollectionType = ContentCollectionType.Album,

                ContentItems = new List<Models.ContentCollections.ContentCollectionItem>(),

                CreatedBy = albumModel.CreatedBy,
                CreatedTimestamp = albumModel.CreatedTimestamp,

                LastModifiedBy = albumModel.LastModifiedBy,
                LastModifiedTimestamp = albumModel.LastModifiedTimestamp,

                DeactivatedBy = albumModel.DeactivatedBy,
                DeactivatedTimestamp = albumModel.DeactivatedTimestamp,
                DeactivatedReason = albumModel.DeactivatedReason
            };

            model.ContentItems = albumModel.Items.Select(ToContentCollectionItem).ToList();

            return model;
        }

        public static Models.ContentCollections.ContentCollectionItem ToContentCollectionItem(Models.Albums.AlbumItem albumItem)
        {
            var domainModel = new Models.ContentCollections.ContentCollectionItem
            {
                ContentCollectionItemId = albumItem.AlbumItemId,

                MediaType = albumItem.MediaType,

                ImageId = albumItem.ImageId,
                Image = albumItem.Image,

                VideoId = albumItem.VideoId,
                Video = albumItem.Video,

                AudioId = albumItem.AudioId,
                Audio = albumItem.Audio,

                LinkId = albumItem.LinkId,
                Link = albumItem.Link,

                CreatedBy = albumItem.CreatedBy,
                CreatedTimestamp = albumItem.CreatedTimestamp,

                LastModifiedBy = albumItem.LastModifiedBy,
                LastModifiedTimestamp = albumItem.LastModifiedTimestamp,

                DeactivatedBy = albumItem.DeactivatedBy,
                DeactivatedTimestamp = albumItem.DeactivatedTimestamp,
                DeactivatedReason = albumItem.DeactivatedReason
            };

            return domainModel;
        }

        public static Models.ContentCollections.DomainTransferObjects.AddContentCollectionDto ToAddContentCollectionDto(Models.Albums.DomainTransferObjects.AddAlbumDto albumDto)
        {
            var model = new Models.ContentCollections.DomainTransferObjects.AddContentCollectionDto
            {
                Name = albumDto.Name,
                CollectionType = ContentCollectionType.Album,

                ContentItems = new List<Models.ContentCollections.DomainTransferObjects.ContentCollectionItemDto>()
            };

            model.ContentItems = albumDto.Items.Select(ToAddContentCollectionItemDto).ToList();

            return model;
        }

        public static Models.ContentCollections.DomainTransferObjects.ContentCollectionItemDto ToAddContentCollectionItemDto(Models.Albums.DomainTransferObjects.AlbumItemDto albumItemDto)
        {
            var model = new Models.ContentCollections.DomainTransferObjects.ContentCollectionItemDto
            {
                Id = albumItemDto.Id,
                MediaType = albumItemDto.MediaType,

                Link = albumItemDto.Link,
                LinkId = albumItemDto.LinkId,

                Image = albumItemDto.Image,
                ImageId = albumItemDto.ImageId,

                Video = albumItemDto.Video,
                VideoId = albumItemDto.VideoId,

                Audio = albumItemDto.Audio,
                AudioId = albumItemDto.AudioId,

                CreatedBy = albumItemDto.CreatedBy,
                CreatedTimestamp = albumItemDto.CreatedTimestamp,

                LastModifiedBy = albumItemDto.LastModifiedBy,
                LastModifiedTimestamp = albumItemDto.LastModifiedTimestamp,

                DeactivatedBy = albumItemDto.DeactivatedBy,
                DeactivatedTimestamp = albumItemDto.DeactivatedTimestamp,
                DeactivatedReason = albumItemDto.DeactivatedReason
            };

            return model;
        }

        public static Models.Albums.Album ToAlbum(Models.ContentCollections.ContentCollection contentCollectionModel)
        {
            var model = new Models.Albums.Album
            {
                AlbumId = contentCollectionModel.ContentCollectionId,

                Name = contentCollectionModel.Name,

                Items = new List<Models.Albums.AlbumItem>(),

                CreatedBy = contentCollectionModel.CreatedBy,
                CreatedTimestamp = contentCollectionModel.CreatedTimestamp,

                LastModifiedBy = contentCollectionModel.LastModifiedBy,
                LastModifiedTimestamp = contentCollectionModel.LastModifiedTimestamp,

                DeactivatedBy = contentCollectionModel.DeactivatedBy,
                DeactivatedTimestamp = contentCollectionModel.DeactivatedTimestamp,
                DeactivatedReason = contentCollectionModel.DeactivatedReason
            };

            model.Items = contentCollectionModel.ContentItems.Select(ToAlbumItem).ToList();

            return model;
        }

        public static Models.Albums.AlbumItem ToAlbumItem(Models.ContentCollections.ContentCollectionItem contentCollectionItem)
        {
            var domainModel = new  Models.Albums.AlbumItem
            {
                AlbumItemId = contentCollectionItem.ContentCollectionItemId,

                MediaType = contentCollectionItem.MediaType,

                ImageId = contentCollectionItem.ImageId,
                Image = contentCollectionItem.Image,

                VideoId = contentCollectionItem.VideoId,
                Video = contentCollectionItem.Video,

                AudioId = contentCollectionItem.AudioId,
                Audio = contentCollectionItem.Audio,

                LinkId = contentCollectionItem.LinkId,
                Link = contentCollectionItem.Link,

                CreatedBy = contentCollectionItem.CreatedBy,
                CreatedTimestamp = contentCollectionItem.CreatedTimestamp,

                LastModifiedBy = contentCollectionItem.LastModifiedBy,
                LastModifiedTimestamp = contentCollectionItem.LastModifiedTimestamp,

                DeactivatedBy = contentCollectionItem.DeactivatedBy,
                DeactivatedTimestamp = contentCollectionItem.DeactivatedTimestamp,
                DeactivatedReason = contentCollectionItem.DeactivatedReason
            };

            return domainModel;
        }

    }
}