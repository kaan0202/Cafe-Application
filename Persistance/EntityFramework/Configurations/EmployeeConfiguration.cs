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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id).HasName("EmployeeId");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(43);
            builder.Property(e => e.Password).IsRequired();
            builder.Property(e => e.Surname).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(10);
            
            builder.Property(e => e.Address).IsRequired();
        }
    }
}
