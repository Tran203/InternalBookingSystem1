using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InternalBookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookedBy", "EndTime", "Purpose", "ResourceId", "StartTime" },
                values: new object[,]
                {
                    { 1, "Thandi Mokoena", new DateTime(2025, 7, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "Team Strategy Meeting", 1, new DateTime(2025, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Jabu Mabaso", new DateTime(2025, 7, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Video Conference with Clients", 2, new DateTime(2025, 7, 16, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "2nd Floor, Jorissen Place", "Meeting Room A" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Location", "Name" },
                values: new object[] { 8, "Medium room with video conferencing", false, "3rd Floor, Jorissen Place", "Meeting Room B" });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Capacity", "Description", "IsAvailable", "Location", "Name" },
                values: new object[,]
                {
                    { 3, 12, "Executive boardroom with teleconferencing", true, "1st Floor, Admin Block", "Boardroom Alpha" },
                    { 4, 15, "Executive boardroom", false, "1st Floor, Admin Block", "Boardroom Beta" },
                    { 5, 4, "Compact sedan", true, "Parking Bay 5", "Company Car 1" },
                    { 6, 5, "SUV for field operations", false, "Parking Bay 7", "Company Car 2" },
                    { 7, 2, "Van for delivery", true, "Garage Bay C", "Delivery Van" },
                    { 8, 1, "High-performance laptop", false, "IT Office", "Laptop A" },
                    { 9, 1, "Standard laptop", true, "IT Office", "Laptop B" },
                    { 10, 1, "MacBook for design team", false, "Data Team", "MacBook Pro" },
                    { 11, 1, "Workstation", true, "Asset Management Office", "Desktop PC 1" },
                    { 12, 1, "Projector for presentations", true, "Asset Management Office", "Projector X" },
                    { 13, 1, "Speaker set for events", false, "Store Room", "Portable Speaker" },
                    { 14, 4, "Set of 4 wireless mics", true, "Store Room", "Wireless Microphones" },
                    { 15, 1, "Color printer", false, "Ground Floor", "Printer - Main Tower" },
                    { 16, 1, "Comfortable Chair", true, "Admin Supply Room", "Chair X" },
                    { 17, 1, "Portable router", true, "IT Storage", "Mobile WiFi Router" },
                    { 18, 15, "Warm food", false, "4th Floor, Kitchen Block", "Microwave" },
                    { 19, 1, "Cool Stuff", true, "4th Floor, Kitchen Block", "Fridge" },
                    { 20, 1, "Gaming console with monitor", true, "5th Floor, Gaming Room", "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookedBy", "EndTime", "Purpose", "ResourceId", "StartTime" },
                values: new object[,]
                {
                    { 2, "Sipho Ngubane", new DateTime(2025, 7, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Client Site Visit", 5, new DateTime(2025, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Lerato Khumalo", new DateTime(2025, 7, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "Software Development", 8, new DateTime(2025, 7, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Nomsa Dlamini", new DateTime(2025, 7, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "Printing Reports", 15, new DateTime(2025, 7, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Thabo Sithole", new DateTime(2025, 7, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "Field Inspection", 6, new DateTime(2025, 7, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Zanele Nkosi", new DateTime(2025, 7, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "Field Event", 13, new DateTime(2025, 7, 22, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Mpho Radebe", new DateTime(2025, 7, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), "Executive Briefing", 3, new DateTime(2025, 7, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Tumi Ndebele", new DateTime(2025, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "Document Delivery", 7, new DateTime(2025, 7, 18, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Lerato Khumalo", new DateTime(2025, 7, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "Graphic Design Project", 10, new DateTime(2025, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Naledi Tshabalala", new DateTime(2025, 7, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "Presentation Setup", 12, new DateTime(2025, 7, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Lerato Khumalo", new DateTime(2025, 7, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), "Team Bonding Session", 20, new DateTime(2025, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "2nd Floor", "Meeting Room Alpha" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Location", "Name" },
                values: new object[] { 4, "Compact sedan", true, "Parking Bay 5", "Company Car 1" });
        }
    }
}
