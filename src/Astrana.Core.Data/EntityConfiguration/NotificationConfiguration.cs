/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Workflow;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Notifications.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureNotification(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new NotificationConfiguration());
        }
    }

    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Type)
                .IsRequired()
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.Message)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Notification.MaximumMessageLength)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.SourceType)
                .IsRequired()
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.SourceId)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Notification.MaximumSourceIdLength)
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.IsRead)
                .IsRequired()
                .HasColumnOrder(5);
        
            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
