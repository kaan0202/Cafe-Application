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
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
           builder.HasKey(x => x.Id).HasName("OfferId");
            builder.Property(x => x.OfferName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.OfferPercent).IsRequired().HasMaxLength(3);
            builder.Property(x => x.OfferTime).IsRequired();
            builder.Property(x => x.OfferStatus).IsRequired();
            builder.Property(x => x.OfferDescription).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.Category).WithMany(o => o.Offers).HasForeignKey(o => o.CategoryId).HasConstraintName("Ofs_cat");


        }
    }
}
