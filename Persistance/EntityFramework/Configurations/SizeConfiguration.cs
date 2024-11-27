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
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasKey(x => x.Id).HasName("SizeId");
            builder.Property(x =>x.Name).IsRequired().HasMaxLength(10);
            builder.HasMany(x => x.ProductDetails).WithOne(x => x.Size).HasForeignKey(x => x.SizeId).HasConstraintName("Prodtls_size");   
        }
    }
}
