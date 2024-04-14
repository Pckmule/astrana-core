/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.AudioClips.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureAudio(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new AudioClipsConfiguration());
        }
    }

    public class AudioClipsConfiguration : IEntityTypeConfiguration<AudioClip>
    {
        public void Configure(EntityTypeBuilder<AudioClip> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Location)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.AudioClip.MaximumLocationLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.Caption)
                .HasMaxLength(DomainModelProperties.AudioClip.MaximumCaptionLength)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Copyright)
                .HasMaxLength(DomainModelProperties.AudioClip.MaximumCopyrightLength)
                .HasColumnOrder(3);

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
