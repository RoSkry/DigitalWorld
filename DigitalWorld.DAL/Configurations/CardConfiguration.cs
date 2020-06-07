using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
    public class CardConfiguration : BaseConfiguration<Card>
    {
        public CardConfiguration() : base("Card")
        {
        }
        public override void Configure(EntityTypeBuilder<Card> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Type).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Information).IsRequired().HasMaxLength(255);

            builder.HasOne(e => e.Category).WithMany(e => e.Cards);
        }
    }

}
