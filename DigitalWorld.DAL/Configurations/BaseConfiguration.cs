using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalWorld.DAL.Configurations
{
    public class BaseConfiguration<TEntityType> : IEntityTypeConfiguration<TEntityType>
        where TEntityType : BaseEntity
    {
        private readonly string _tableName;
        public BaseConfiguration(string tableName)
        {
            _tableName = tableName;
        }


        public virtual void Configure(EntityTypeBuilder<TEntityType> builder)
        {
            builder.ToTable(_tableName, "dbo");
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
