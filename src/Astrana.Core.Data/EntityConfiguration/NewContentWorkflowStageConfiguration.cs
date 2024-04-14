/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Workflow;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureNewContentWorkflowStage(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new NewContentWorkflowStageConfiguration());
        }
    }

    public class NewContentWorkflowStageConfiguration : IEntityTypeConfiguration<NewContentWorkflowStage>
    {
        public void Configure(EntityTypeBuilder<NewContentWorkflowStage> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.ContentEntityId)
                .IsRequired()
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.ContentEntityTypeId)
                .IsRequired()
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Stage)
                .IsRequired()
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
