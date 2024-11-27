using Domain.Entities.App;
using Domain.Entities.Common;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityFramework.Contexts
{
    public class CafeDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public CafeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<SideProduct> SideProducts { get; set; }
        public DbSet<Size> Sizes { get; set; }

        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var entity in datas)
            {
                _ = entity.State switch
                {
                    EntityState.Added => entity.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => entity.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var entity in datas)
            {
                _ = entity.State switch
                {
                    EntityState.Added => entity.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => entity.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().ToTable("Products", builder => builder.HasComment("Bu tablo ürünlerin bilgilerini tutmaktadır."));
            builder.Entity<Employee>().ToTable("Employees", builder => builder.HasComment("Bu tablo çalışanların bilgilerini tutmaktadır."));
            builder.Entity<Customer>().ToTable("Customers", builder => builder.HasComment("Bu tablo müşterilerin bilgilerini tutmaktadır."));
            builder.Entity<Offer>().ToTable("Offers", builder => builder.HasComment("Bu tablo kampanyaların bilgilerini tutmaktadır."));
            builder.Entity<Order>().ToTable("Orders", builder => builder.HasComment("Bu tablo siparişlerin bilgilerini tutmaktadır."));
            builder.Entity<ProductDetail>().ToTable("ProductDetails", builder => builder.HasComment("Bu tablo ürünlerin detay bilgilerini tutmaktadır."));
            builder.Entity<SideProduct>().ToTable("SideProducts", builder => builder.HasComment("Bu tablo yan ürünlerin  bilgilerini tutmaktadır."));
            builder.Entity<Size>().ToTable("Sizes", builder => builder.HasComment("Bu tablo boyutları bilgilerini tutmaktadır."));
            builder.Entity<Category>().ToTable("Categories", builder => builder.HasComment("Bu tablo kategorilerin bilgilerini tutmaktadır."));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
           
        }

    }
}
