/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Links.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureLink(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new LinkConfiguration());
        }
    }

    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Url)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Link.MaximumUrlLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Link.MaximumTitleLength)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Link.MaximumDescriptionLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.Locale)
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.CharSet)
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.Robots)
                .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.SiteName)
                .HasColumnOrder(7);

            //entityTypeBuilder.Property(p => p.PreviewImage)
            //    .HasColumnOrder(8);

            entityTypeBuilder.Property(p => p.PreviewImageId)
                .HasColumnOrder(8);

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
