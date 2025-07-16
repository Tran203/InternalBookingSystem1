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
            .HasForeignKey(b => b.ResourceId)
            .OnDelete(DeleteBehavior.SetNull);


            //Prepopulate Resources
            modelBuilder.Entity<Resource>().HasData(
                // Meeting Rooms
                new Resource { Id = 1, Name = "Meeting Room A", Description = "Large room with projector", Location = "2nd Floor, Jorissen Place", Capacity = 10, IsAvailable = true },
                new Resource { Id = 2, Name = "Meeting Room B", Description = "Medium room with video conferencing", Location = "3rd Floor, Jorissen Place", Capacity = 8, IsAvailable = false },
                new Resource { Id = 3, Name = "Boardroom Alpha", Description = "Executive boardroom with teleconferencing", Location = "1st Floor, Admin Block", Capacity = 12, IsAvailable = true },
                new Resource { Id = 4, Name = "Boardroom Beta", Description = "Executive boardroom", Location = "1st Floor, Admin Block", Capacity = 15, IsAvailable = false },

                // Company Vehicles
                new Resource { Id = 5, Name = "Company Car 1", Description = "Compact sedan", Location = "Parking Bay 5", Capacity = 4, IsAvailable = true },
                new Resource { Id = 6, Name = "Company Car 2", Description = "SUV for field operations", Location = "Parking Bay 7", Capacity = 5, IsAvailable = false },
                new Resource { Id = 7, Name = "Delivery Van", Description = "Van for delivery", Location = "Garage Bay C", Capacity = 2, IsAvailable = true },

                // IT Equipment
                new Resource { Id = 8, Name = "Laptop A", Description = "High-performance laptop", Location = "IT Office", Capacity = 1, IsAvailable = false },
                new Resource { Id = 9, Name = "Laptop B", Description = "Standard laptop", Location = "IT Office", Capacity = 1, IsAvailable = true },
                new Resource { Id = 10, Name = "MacBook Pro", Description = "MacBook for design team", Location = "Data Team", Capacity = 1, IsAvailable = false },
                new Resource { Id = 11, Name = "Desktop PC 1", Description = "Workstation", Location = "Asset Management Office", Capacity = 1, IsAvailable = true },

                // AV / Presentation
                new Resource { Id = 12, Name = "Projector X", Description = "Projector for presentations", Location = "Asset Management Office", Capacity = 1, IsAvailable = true },
                new Resource { Id = 13, Name = "Portable Speaker", Description = "Speaker set for events", Location = "Store Room", Capacity = 1, IsAvailable = false },
                new Resource { Id = 14, Name = "Wireless Microphones", Description = "Set of 4 wireless mics", Location = "Store Room", Capacity = 4, IsAvailable = true },

                // Office Utilities
                new Resource { Id = 15, Name = "Printer - Main Tower", Description = "Color printer", Location = "Ground Floor", Capacity = 1, IsAvailable = false },
                new Resource { Id = 16, Name = "Chair X", Description = "Comfortable Chair", Location = "Admin Supply Room", Capacity = 1, IsAvailable = true },
                new Resource { Id = 17, Name = "Mobile WiFi Router", Description = "Portable router", Location = "IT Storage", Capacity = 1, IsAvailable = true },

                // OTHER / Facilities
                new Resource { Id = 18, Name = "Microwave", Description = "Warm food", Location = "4th Floor, Kitchen Block", Capacity = 15, IsAvailable = false },
                new Resource { Id = 19, Name = "Fridge", Description = "Cool Stuff", Location = "4th Floor, Kitchen Block", Capacity = 1, IsAvailable = true },
                new Resource { Id = 20, Name = "Xbox", Description = "Gaming console with monitor", Location = "5th Floor, Gaming Room", Capacity = 1, IsAvailable = true }
            );


            //Prepopulate Bookings
            modelBuilder.Entity<Booking>().HasData(
                // Past Bookings (before July 16, 2025)
                new Booking { Id = 1, ResourceId = 1, StartTime = new DateTime(2025, 7, 10, 9, 0, 0), EndTime = new DateTime(2025, 7, 10, 11, 0, 0), BookedBy = "Thandi Mokoena", Purpose = "Team Strategy Meeting" },
                new Booking { Id = 2, ResourceId = 5, StartTime = new DateTime(2025, 7, 12, 8, 0, 0), EndTime = new DateTime(2025, 7, 12, 12, 0, 0), BookedBy = "Sipho Ngubane", Purpose = "Client Site Visit" },
                new Booking { Id = 3, ResourceId = 8, StartTime = new DateTime(2025, 7, 14, 8, 0, 0), EndTime = new DateTime(2025, 7, 15, 17, 0, 0), BookedBy = "Lerato Khumalo", Purpose = "Software Development" },
                new Booking { Id = 4, ResourceId = 15, StartTime = new DateTime(2025, 7, 15, 9, 0, 0), EndTime = new DateTime(2025, 7, 15, 17, 0, 0), BookedBy = "Nomsa Dlamini", Purpose = "Printing Reports" },

                // Active Bookings (on July 16, 2025)
                new Booking { Id = 5, ResourceId = 2, StartTime = new DateTime(2025, 7, 16, 10, 0, 0), EndTime = new DateTime(2025, 7, 16, 12, 0, 0), BookedBy = "Jabu Mabaso", Purpose = "Video Conference with Clients" },

                // Upcoming Bookings (after July 16, 2025)
                new Booking { Id = 6, ResourceId = 6, StartTime = new DateTime(2025, 7, 28, 13, 0, 0), EndTime = new DateTime(2025, 7, 28, 17, 0, 0), BookedBy = "Thabo Sithole", Purpose = "Field Inspection" },
                new Booking { Id = 7, ResourceId = 13, StartTime = new DateTime(2025, 7, 22, 14, 0, 0), EndTime = new DateTime(2025, 7, 22, 18, 0, 0), BookedBy = "Zanele Nkosi", Purpose = "Field Event" },
                new Booking { Id = 8, ResourceId = 3, StartTime = new DateTime(2025, 7, 29, 9, 0, 0), EndTime = new DateTime(2025, 7, 29, 11, 0, 0), BookedBy = "Mpho Radebe", Purpose = "Executive Briefing" },
                new Booking { Id = 9, ResourceId = 7, StartTime = new DateTime(2025, 7, 18, 8, 0, 0), EndTime = new DateTime(2025, 7, 18, 12, 0, 0), BookedBy = "Tumi Ndebele", Purpose = "Document Delivery" },
                new Booking { Id = 10, ResourceId = 10, StartTime = new DateTime(2025, 7, 22, 8, 0, 0), EndTime = new DateTime(2025, 7, 22, 17, 0, 0), BookedBy = "Lerato Khumalo", Purpose = "Graphic Design Project" },
                new Booking { Id = 11, ResourceId = 12, StartTime = new DateTime(2025, 7, 29, 13, 0, 0), EndTime = new DateTime(2025, 7, 29, 15, 0, 0), BookedBy = "Naledi Tshabalala", Purpose = "Presentation Setup" },
                new Booking { Id = 12, ResourceId = 20, StartTime = new DateTime(2025, 7, 24, 16, 0, 0), EndTime = new DateTime(2025, 7, 24, 18, 0, 0), BookedBy = "Lerato Khumalo", Purpose = "Team Bonding Session" }
            );
        }
    }
}
