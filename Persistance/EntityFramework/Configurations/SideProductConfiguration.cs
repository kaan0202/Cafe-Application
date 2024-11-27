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
    public class SideProductConfiguration : IEntityTypeConfiguration<SideProduct>
    {
        public void Configure(EntityTypeBuilder<SideProduct> builder)
        {
            builder.HasKey(x => x.Id).HasName("SideProductId");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(25);
            builder.HasMany(x => x.Orders).WithOne(x => x.SideProduct).HasForeignKey(x => x.SideProductId);

        }
    }
}
