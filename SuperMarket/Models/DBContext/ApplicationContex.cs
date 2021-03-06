using Microsoft.EntityFrameworkCore;
using SuperMarket.Models.Entities;
using System.Reflection;

namespace SuperMarket.Models.DBContext
{
    public class ApplicationContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Test;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GoodCategory>().HasKey(_ => _.Id);

            modelBuilder.Entity<GoodCategory>().Property(_ => _.Id)
                .ValueGeneratedNever();
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<GoodCategory> GoodCategories { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodEntry> GoodEntries { get; set; }
        public DbSet<GetSalesFactorDtors> SaleFactors { get; set; }
    }
}
