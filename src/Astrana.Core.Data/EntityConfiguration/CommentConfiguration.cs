/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Comments.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureComment(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new CommentConfiguration());
        }
    }

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Text)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Comment.MaximumTextLength)
                .HasColumnOrder(1);

            //entityTypeBuilder.Property(p => p.TargetPost)
            //    .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.TargetPostId)
                .HasColumnOrder(3);

            //entityTypeBuilder.Property(p => p.TargetComment)
            //    .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.TargetCommentId)
                .HasColumnOrder(4);

            //entityTypeBuilder.Property(p => p.TargetImage)
            //    .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.TargetImageId)
                .HasColumnOrder(5);

            //entityTypeBuilder.Property(p => p.TargetVideo)
            //    .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.TargetVideoId)
                .HasColumnOrder(6);

            //entityTypeBuilder.Property(p => p.TargetAudio)
            //    .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.TargetAudioId)
                .HasColumnOrder(7);

            //entityTypeBuilder.Property(p => p.TargetGif)
            //    .HasColumnOrder(8);

            entityTypeBuilder.Property(p => p.TargetGifId)
                .HasColumnOrder(8);

            //entityTypeBuilder.Property(p => p.TargetContentCollection)
            //    .HasColumnOrder(9);

            entityTypeBuilder.Property(p => p.TargetContentCollectionId)
                .HasColumnOrder(9);

            //entityTypeBuilder.Property(p => p.TargetLink)
            //    .HasColumnOrder(10);

            entityTypeBuilder.Property(p => p.TargetLinkId)
                .HasColumnOrder(10);

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
