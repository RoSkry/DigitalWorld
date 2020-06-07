using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
    public class PlayStationConfiguration : BaseConfiguration<PlayStation>
    {
        public PlayStationConfiguration() : base("PlayStation")
        {

        }

        public override void Configure(EntityTypeBuilder<PlayStation> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Type).IsRequired().HasMaxLength(255);
            builder.Property(p => p.CPU).IsRequired().HasMaxLength(255);
            builder.Property(p => p.CPUModel).IsRequired().HasMaxLength(255);
            builder.Property(p => p.CPUFrequency).IsRequired();
            builder.Property(p => p.CoreCount).IsRequired();
            builder.Property(p => p.RAMVolume).IsRequired();
            builder.Property(p => p.InternalMemoryVolume).IsRequired();
            builder.Property(p => p.GraphicCore).IsRequired().HasMaxLength(255);
            builder.Property(p => p.VideoMemoryVolume).IsRequired().HasMaxLength(255);
            builder.Property(p => p.RAMType).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Сomplectation).IsRequired().HasMaxLength(255);

            builder.HasOne(e => e.Category).WithMany(e => e.PlayStations);
            builder.HasOne(e => e.ProductSize).WithMany(e => e.PlayStations);
        }
    }
}
