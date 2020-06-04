using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
    public class ProductSizeConfiguration : IEntityTypeConfiguration<ProductSize>
    {

        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Weight).IsRequired();
            builder.Property(p => p.Dimension).IsRequired().HasMaxLength(255);
        }
    }
}
