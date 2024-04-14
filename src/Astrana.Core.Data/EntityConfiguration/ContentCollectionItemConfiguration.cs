/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureContentCollectionItem(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new ContentCollectionItemConfiguration());
        }
    }

    public class ContentCollectionItemConfiguration : IEntityTypeConfiguration<ContentCollectionItem>
    {
        public void Configure(EntityTypeBuilder<ContentCollectionItem> entityTypeBuilder)
        {
            //entityTypeBuilder.Property(p => p.ContentCollection)
            //    .IsRequired()
            //.HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.ContentCollectionId)
            .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.MediaType)
                .IsRequired()
                .HasColumnOrder(2);

           // entityTypeBuilder.Property(p => p.Link)
           //     .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.LinkId)
                .HasColumnOrder(3);

           // entityTypeBuilder.Property(p => p.Image)
           //     .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.ImageId)
                .HasColumnOrder(4);

            // entityTypeBuilder.Property(p => p.Video)
            //    .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.VideoId)
                .HasColumnOrder(5);

            // entityTypeBuilder.Property(p => p.Audio)
            //    .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.AudioId)
                .HasColumnOrder(6);

            // entityTypeBuilder.Property(p => p.Gif)
            //    .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.GifId)
                .HasColumnOrder(7);

            entityTypeBuilder
                .HasOne(l => l.Link)
                .WithMany()
                .HasForeignKey(u => u.LinkId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder
                .HasOne(l => l.Image)
                .WithMany()
                .HasForeignKey(u => u.ImageId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder
                .HasOne(l => l.Video)
                .WithMany()
                .HasForeignKey(u => u.VideoId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder
                .HasOne(l => l.Audio)
                .WithMany()
                .HasForeignKey(u => u.AudioId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder
                .HasOne(l => l.Gif)
                .WithMany()
                .HasForeignKey(u => u.GifId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.Property(p => p.DeactivatedTimestamp).HasColumnOrder(99993);
            entityTypeBuilder.Property(p => p.DeactivatedReason).HasColumnOrder(99994);
            entityTypeBuilder.Property(p => p.DeactivatedBy).HasColumnOrder(99995);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
