using Microsoft.EntityFrameworkCore;
using SmartShiftScheduler.Models;

namespace SmartShiftScheduler
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-many: Staff -> TaskItems
            modelBuilder.Entity<Staff>()
                .HasMany(s => s.Tasks)
                .WithOne(t => t.Staff)
                .HasForeignKey(t => t.StaffID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-many: Staff -> Shifts
            modelBuilder.Entity<Staff>()
                .HasMany(s => s.Shifts)
                .WithOne(sh => sh.Staff)
                .HasForeignKey(sh => sh.StaffID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
