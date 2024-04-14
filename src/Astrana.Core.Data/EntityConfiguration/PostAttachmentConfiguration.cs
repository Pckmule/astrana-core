/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Posts.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigurePostAttachment(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new PostAttachmentConfiguration());
        }
    }

    public class PostAttachmentConfiguration : IEntityTypeConfiguration<PostAttachment>
    {
        public void Configure(EntityTypeBuilder<PostAttachment> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.PostAttachment.MaximumTitleLength)
                .HasDefaultValue(null)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.Caption)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.PostAttachment.MaximumCaptionLength)
                .HasDefaultValue(null)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Type)
                .IsRequired()
                .HasColumnOrder(3);

            // entityTypeBuilder.Property(p => p.Link)
            //     .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.LinkId)
                .HasColumnOrder(4);

            //entityTypeBuilder.Property(p => p.Image)
            //    .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.ImageId)
                .HasColumnOrder(5);

            //entityTypeBuilder.Property(p => p.Video)
            //    .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.VideoId)
                .HasColumnOrder(6);

            //entityTypeBuilder.Property(p => p.AudioClip)
            //    .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.AudioClipId)
                .HasColumnOrder(7);

            //entityTypeBuilder.Property(p => p.ContentCollection)
            //    .HasColumnOrder(8);

            entityTypeBuilder.Property(p => p.ContentCollectionId)
                .HasColumnOrder(8);

            //entityTypeBuilder.Property(p => p.Gif)
            //    .HasColumnOrder(9);

            entityTypeBuilder.Property(p => p.GifId)
                .HasColumnOrder(9);

            //entityTypeBuilder.Property(p => p.Feeling)
            //    .HasColumnOrder(10);

            entityTypeBuilder.Property(p => p.FeelingId)
                .HasColumnOrder(10);
            
            //entityTypeBuilder.Property(p => p.Location)
            //    .HasColumnOrder(11);

            entityTypeBuilder.Property(p => p.LocationId)
                .HasColumnOrder(11);
            
            entityTypeBuilder.HasOne(l => l.ContentCollection)
                .WithMany()
                .HasForeignKey(u => u.ContentCollectionId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.Link)
                .WithMany()
                .HasForeignKey(u => u.LinkId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.Image)
                .WithMany()
                .HasForeignKey(u => u.ImageId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.Video)
                .WithMany()
                .HasForeignKey(u => u.VideoId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.AudioClip)
                .WithMany()
                .HasForeignKey(u => u.AudioClipId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.Gif)
                .WithMany()
                .HasForeignKey(u => u.GifId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.Feeling)
                .WithMany()
                .HasForeignKey(u => u.FeelingId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.HasOne(l => l.Location)
                .WithMany()
                .HasForeignKey(u => u.LocationId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            entityTypeBuilder.Property(p => p.DeactivatedTimestamp).HasColumnOrder(99993);
            entityTypeBuilder.Property(p => p.DeactivatedReason).HasDefaultValue(null).HasColumnOrder(99994);
            entityTypeBuilder.Property(p => p.DeactivatedBy).HasColumnOrder(99995);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
