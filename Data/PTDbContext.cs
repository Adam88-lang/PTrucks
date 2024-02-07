using Microsoft.EntityFrameworkCore;
using PTrucks.Models;


namespace PTrucks.Data
{
    public class PTDbContext : DbContext
    {
        public PTDbContext(DbContextOptions<PTDbContext> options)
            : base(options)
        {
        }   

        public DbSet<DeviceLocation> DeviceLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceLocation>().ToTable("Location");
        }

    }
}
