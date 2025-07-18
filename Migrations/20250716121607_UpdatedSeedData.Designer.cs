﻿// <auto-generated />
using System;
using InternalBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InternalBookingSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250716121607_UpdatedSeedData")]
    partial class UpdatedSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InternalBookingSystem.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BookedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ResourceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookedBy = "Thandi Mokoena",
                            EndTime = new DateTime(2025, 7, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Team Strategy Meeting",
                            ResourceId = 1,
                            StartTime = new DateTime(2025, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            BookedBy = "Sipho Ngubane",
                            EndTime = new DateTime(2025, 7, 12, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Client Site Visit",
                            ResourceId = 5,
                            StartTime = new DateTime(2025, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BookedBy = "Lerato Khumalo",
                            EndTime = new DateTime(2025, 7, 15, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Software Development",
                            ResourceId = 8,
                            StartTime = new DateTime(2025, 7, 14, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            BookedBy = "Nomsa Dlamini",
                            EndTime = new DateTime(2025, 7, 15, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Printing Reports",
                            ResourceId = 15,
                            StartTime = new DateTime(2025, 7, 15, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            BookedBy = "Jabu Mabaso",
                            EndTime = new DateTime(2025, 7, 16, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Video Conference with Clients",
                            ResourceId = 2,
                            StartTime = new DateTime(2025, 7, 16, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            BookedBy = "Thabo Sithole",
                            EndTime = new DateTime(2025, 7, 28, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Field Inspection",
                            ResourceId = 6,
                            StartTime = new DateTime(2025, 7, 28, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            BookedBy = "Zanele Nkosi",
                            EndTime = new DateTime(2025, 7, 22, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Field Event",
                            ResourceId = 13,
                            StartTime = new DateTime(2025, 7, 22, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            BookedBy = "Mpho Radebe",
                            EndTime = new DateTime(2025, 7, 29, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Executive Briefing",
                            ResourceId = 3,
                            StartTime = new DateTime(2025, 7, 29, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            BookedBy = "Tumi Ndebele",
                            EndTime = new DateTime(2025, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Document Delivery",
                            ResourceId = 7,
                            StartTime = new DateTime(2025, 7, 18, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            BookedBy = "Lerato Khumalo",
                            EndTime = new DateTime(2025, 7, 22, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Graphic Design Project",
                            ResourceId = 10,
                            StartTime = new DateTime(2025, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            BookedBy = "Naledi Tshabalala",
                            EndTime = new DateTime(2025, 7, 29, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Presentation Setup",
                            ResourceId = 12,
                            StartTime = new DateTime(2025, 7, 29, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            BookedBy = "Lerato Khumalo",
                            EndTime = new DateTime(2025, 7, 24, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Purpose = "Team Bonding Session",
                            ResourceId = 20,
                            StartTime = new DateTime(2025, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("InternalBookingSystem.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 10,
                            Description = "Large room with projector",
                            IsAvailable = true,
                            Location = "2nd Floor, Jorissen Place",
                            Name = "Meeting Room A"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 8,
                            Description = "Medium room with video conferencing",
                            IsAvailable = false,
                            Location = "3rd Floor, Jorissen Place",
                            Name = "Meeting Room B"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 12,
                            Description = "Executive boardroom with teleconferencing",
                            IsAvailable = true,
                            Location = "1st Floor, Admin Block",
                            Name = "Boardroom Alpha"
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 15,
                            Description = "Executive boardroom",
                            IsAvailable = false,
                            Location = "1st Floor, Admin Block",
                            Name = "Boardroom Beta"
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 4,
                            Description = "Compact sedan",
                            IsAvailable = true,
                            Location = "Parking Bay 5",
                            Name = "Company Car 1"
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 5,
                            Description = "SUV for field operations",
                            IsAvailable = false,
                            Location = "Parking Bay 7",
                            Name = "Company Car 2"
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 2,
                            Description = "Van for delivery",
                            IsAvailable = true,
                            Location = "Garage Bay C",
                            Name = "Delivery Van"
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 1,
                            Description = "High-performance laptop",
                            IsAvailable = false,
                            Location = "IT Office",
                            Name = "Laptop A"
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 1,
                            Description = "Standard laptop",
                            IsAvailable = true,
                            Location = "IT Office",
                            Name = "Laptop B"
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 1,
                            Description = "MacBook for design team",
                            IsAvailable = false,
                            Location = "Data Team",
                            Name = "MacBook Pro"
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 1,
                            Description = "Workstation",
                            IsAvailable = true,
                            Location = "Asset Management Office",
                            Name = "Desktop PC 1"
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 1,
                            Description = "Projector for presentations",
                            IsAvailable = true,
                            Location = "Asset Management Office",
                            Name = "Projector X"
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 1,
                            Description = "Speaker set for events",
                            IsAvailable = false,
                            Location = "Store Room",
                            Name = "Portable Speaker"
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 4,
                            Description = "Set of 4 wireless mics",
                            IsAvailable = true,
                            Location = "Store Room",
                            Name = "Wireless Microphones"
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 1,
                            Description = "Color printer",
                            IsAvailable = false,
                            Location = "Ground Floor",
                            Name = "Printer - Main Tower"
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 1,
                            Description = "Comfortable Chair",
                            IsAvailable = true,
                            Location = "Admin Supply Room",
                            Name = "Chair X"
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 1,
                            Description = "Portable router",
                            IsAvailable = true,
                            Location = "IT Storage",
                            Name = "Mobile WiFi Router"
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 15,
                            Description = "Warm food",
                            IsAvailable = false,
                            Location = "4th Floor, Kitchen Block",
                            Name = "Microwave"
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 1,
                            Description = "Cool Stuff",
                            IsAvailable = true,
                            Location = "4th Floor, Kitchen Block",
                            Name = "Fridge"
                        },
                        new
                        {
                            Id = 20,
                            Capacity = 1,
                            Description = "Gaming console with monitor",
                            IsAvailable = true,
                            Location = "5th Floor, Gaming Room",
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("InternalBookingSystem.Models.Booking", b =>
                {
                    b.HasOne("InternalBookingSystem.Models.Resource", "Resource")
                        .WithMany("Bookings")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("InternalBookingSystem.Models.Resource", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
