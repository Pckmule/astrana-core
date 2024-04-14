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
        public static ModelBuilder ConfigurePeer(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new PeerConfiguration());
        }
    }

    public class PeerConfiguration : IEntityTypeConfiguration<Peer>
    {
        public void Configure(EntityTypeBuilder<Peer> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.VirtualProfileId)
                .IsRequired()
                .HasColumnOrder(1);

            entityTypeBuilder.HasIndex(p => p.VirtualProfileId).IsUnique();

            entityTypeBuilder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Peer.MaximumFirstNameLength)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Peer.MaximumLastNameLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.Age)
                .IsRequired()
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.Sex)
                .IsRequired()
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Peer.MaximumAddressLength)
                .HasColumnOrder(6);

            entityTypeBuilder.HasIndex(p => p.Address).IsUnique();

            entityTypeBuilder.Property(p => p.Note)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Peer.MaximumNoteLength)
                .HasColumnOrder(7);
            
            entityTypeBuilder.Property(p => p.PeerAccessToken)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Peer.MaximumPeerAccessTokenLength)
                .HasColumnOrder(8);
            
            entityTypeBuilder.Property(p => p.IsMuted)
                .IsRequired()
                .HasColumnOrder(9);

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
