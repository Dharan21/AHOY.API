using AHOY.DataEntities.Entities;
using AHOY.Utilities;
using Microsoft.EntityFrameworkCore;

namespace AHOY.DataEntities
{
    public class AhoyContext : DbContext
    {

        public DbSet<Hotel> Hotel { get; set; }

        public AhoyContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(ConfigurationSettings.AhoyDbConnectionString);
        }
    }
}