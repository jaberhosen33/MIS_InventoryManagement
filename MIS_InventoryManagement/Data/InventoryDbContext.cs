
using Microsoft.EntityFrameworkCore;
using MIS_InventoryManagement.Models;

namespace MIS_InventoryManagement.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }

        // DbSets go here
        public DbSet<StafInformation> StafInformations { get; set; }
        public DbSet<PcInformation> PcInformations { get; set; }
        public DbSet<Accessories> Accessories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
