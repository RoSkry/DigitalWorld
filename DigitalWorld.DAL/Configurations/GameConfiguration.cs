using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
   public class GameConfiguration:BaseConfiguration<Game>
    {
        public GameConfiguration() : base("Game")
        {

        }
        public override void Configure(EntityTypeBuilder<Game> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Localization).IsRequired().HasMaxLength(255);
            builder.Property(p => p.AgeLimit).IsRequired();
            builder.Property(p => p.DevCompany).IsRequired().HasMaxLength(255);

            builder.HasOne(e => e.Category).WithMany(e => e.Games);
        }
    }
}
