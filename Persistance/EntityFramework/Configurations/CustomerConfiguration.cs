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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
           
           builder.HasKey(x => x.Id).HasName("CustomerId");
           builder.Property(x => x.Password).IsRequired().HasMaxLength(15);
           builder.Property(x => x.Surname).IsRequired().HasMaxLength(50);
           builder.Property(x => x.Email).IsRequired();
           builder.Property(x => x.Name).IsRequired().HasMaxLength(43);
           builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);
            
           builder.HasMany(x => x.Orders).WithOne(x => x.Customer).HasForeignKey(x =>x.CustomerId).HasConstraintName("Cus_orders");

        }
    }
}
