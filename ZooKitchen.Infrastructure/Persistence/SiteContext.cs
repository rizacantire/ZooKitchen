using ZooKitchen.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ZooKitchen.Infrastructure.Persistence
{
    public class SiteContext : DbContext
    {
        public SiteContext()
        {
        }

        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {

        }
        public DbSet<Animal> Animals { get; set; }  // Hayvanlar tablosu
        public DbSet<Product> Products { get; set; }      // Yiyecekler tablosu
        public DbSet<DeliveryDetail> DeliveryDetails { get; set; }  // Gönderim detayları tablosu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlite("Data Source = ..//productTracking.db");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API ile ilişkileri tanımlamak gerekirse buraya yazabilirsin
        }

    }
}
