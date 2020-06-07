using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
   public class GamePadConfiguration: BaseConfiguration<GamePad>
   {
        public GamePadConfiguration():base("GamePad")
        {
                
        }

        public override void Configure(EntityTypeBuilder<GamePad> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Type).IsRequired().HasMaxLength(255);
            builder.Property(p => p.ButtonsCount).IsRequired();
            builder.Property(p => p.Сompatibility).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Battery).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.HasOne(e => e.Category).WithMany(e => e.GamePads);
            builder.HasOne(e => e.ProductSize).WithMany(e => e.GamePads);
        }
    }
}
