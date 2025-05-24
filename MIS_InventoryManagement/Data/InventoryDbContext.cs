
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

            // Accessories → StafInformation
            modelBuilder.Entity<Accessories>()
                .HasOne(a => a.Staf)
                .WithMany(s => s.Accessories)
                .HasForeignKey(a => a.StaffId)
                .OnDelete(DeleteBehavior.Restrict); // <-- prevent multiple cascade paths

            // Accessories → PcInformation
            modelBuilder.Entity<Accessories>()
                .HasOne(a => a.Pc)
                .WithMany(p => p.Accessories)
                .HasForeignKey(a => a.PC_SLNO)
                .OnDelete(DeleteBehavior.Cascade); // Optional: cascade when PC is deleted

            // PcInformation → StafInformation
            modelBuilder.Entity<PcInformation>()
                .HasOne(p => p.Staf)
                .WithMany(s => s.PcInformations)
                .HasForeignKey(p => p.StafId)
                .OnDelete(DeleteBehavior.Restrict); // Or Cascade if this is safe
        }
    }
}
