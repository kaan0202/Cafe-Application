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
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(x => x.Id).HasName("ProductDetailId");
            builder.Property(x => x.ProductDescription).IsRequired().HasMaxLength(25);
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetail);
            builder.HasOne(x => x.Size).WithMany(x => x.ProductDetails).HasForeignKey(x => x.SizeId);    
        }
    }
}
