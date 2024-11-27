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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id).HasName("ProductId");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(25);
            builder.Property(x => x.Price).IsRequired().HasPrecision(3,2).HasMaxLength(6);
            builder.Property(x => x.StockStatus).IsRequired();
            builder.HasOne(x => x.ProductDetail).WithOne(x => x.Product).HasConstraintName("Pro_prodtls");
            
            
        }
    }
}
