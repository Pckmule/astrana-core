/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Peers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Peers.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigurePeerCircle(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new PeerCircleConfiguration());
        }
    }

    public class PeerCircleConfiguration : IEntityTypeConfiguration<PeerCircle>
    {
        public void Configure(EntityTypeBuilder<PeerCircle> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.PeerCircle.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .HasMaxLength(DomainModelProperties.PeerCircle.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.PeerCircle.MaximumDescriptionLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.DescriptionTrxCode)
                .HasMaxLength(DomainModelProperties.PeerCircle.MaximumDescriptionTrxCodeLength)
                .HasColumnOrder(4);

            //entityTypeBuilder.Property(p => p.Peers)
            //    .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.IsUserDefined)
                .IsRequired()
                .HasColumnOrder(6);
            
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
