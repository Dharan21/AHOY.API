using AHOY.DataEntities.Entities;
using AHOY.Utilities;
using Microsoft.EntityFrameworkCore;

namespace AHOY.DataEntities
{
    public class AhoyContext : DbContext
    {

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FacilityMaster> FacilityMaster { get; set; }
        public DbSet<HotelFacility> HotelFacilities { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public AhoyContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(ConfigurationSettings.AhoyDbConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasIndex(x => x.Email).IsUnique();
        }
    }
}