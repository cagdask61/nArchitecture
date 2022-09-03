using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Brand> Brands { get; set; }
       

        public BaseDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(builder =>
            {
                builder.ToTable("Brands").HasKey(k => k.Id);
                builder.Property(brand => brand.Id).HasColumnName("Id");
                builder.Property(brand => brand.Name).HasColumnName("Name");
                builder.Property(brand => brand.IsApproved).HasColumnName("IsApproved");
                builder.Property(brand => brand.UpdatedDate).HasColumnName("UpdatedDate");
                builder.Property(brand => brand.CreatedDate).HasColumnName("CreatedDate");
            });



            //Brand[] brandEntitySeeds = { new(1, "BMW",true), new(2, "Mercedes", true), new(3, "Audi", true), new(4, "Fiat", true) };
            //modelBuilder.Entity<Brand>().HasData(brandEntitySeeds);

           
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entities = ChangeTracker.Entries<Entity>();

            foreach (var item in entities)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };                
            }

            /*
                switch (item.State)
                {
                    //case EntityState.Detached:
                    //    break;
                    //case EntityState.Unchanged:
                    //    break;
                    //case EntityState.Deleted:
                    //    break;
                    case EntityState.Modified:
                        item.Entity.UpdatedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        _ = DateTime.Now;
                        break;
                }
                */

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
