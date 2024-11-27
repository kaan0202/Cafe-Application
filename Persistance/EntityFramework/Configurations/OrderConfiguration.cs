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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           builder.HasKey(o => o.Id).HasName("OrderId");
            builder.Property(o => o.Quantity).IsRequired().HasMaxLength(9);
            builder.HasIndex(o => o.OrderCode).IsUnique();
            builder.Property(o => o.ProductId).IsRequired();
            builder.HasOne(o => o.Offer).WithMany(o => o.Orders).HasForeignKey(o => o.OfferId).HasConstraintName("Ordrs_ofs");   
        }
    }
}
