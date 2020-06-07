using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public CategoryConfiguration() : base("Category")
        {

        }

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}
