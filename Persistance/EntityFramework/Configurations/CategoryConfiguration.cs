using Domain.Entities.App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityFramework.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            
            builder.HasKey(x => x.Id).HasName("CategoryId");
            builder.Property(x => x.CategoryName).IsRequired();
            
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x=>x.CategoryId).HasConstraintName("Cat_pros");

        }
    }
}
