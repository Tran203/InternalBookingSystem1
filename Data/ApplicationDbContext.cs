using InternalBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InternalBookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Resource> Resources { get; set; }
        public DbSet<Models.Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DB Relationships
            modelBuilder.Entity<Booking>()
            .HasOne(b => b.Resource)
            .WithMany(r => r.Bookings)
            .HasForeignKey(b => b.ResourceId);


            //Prepopulate Resources
            modelBuilder.Entity<Resource>().HasData(
                new Resource { Id = 1, Name = "Meeting Room Alpha", Description = "Large room with projector", Location = "2nd Floor", Capacity = 10, IsAvailable = true },
                new Resource { Id = 2, Name = "Company Car 1", Description = "Compact sedan", Location = "Parking Bay 5", Capacity = 4, IsAvailable = true }
            );
        }
    }
}
