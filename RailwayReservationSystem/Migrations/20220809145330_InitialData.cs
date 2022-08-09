using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailwayReservationSystem.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNIC = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    TicketNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.TicketNo);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    SchduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainNo = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Journey = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.SchduleId);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    TrainNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    SeatsBooked = table.Column<int>(type: "int", nullable: false),
                    SeatsAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.TrainNo);
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Age", "CNIC", "Contact", "DOB", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 26, 61101, 336, new DateTime(1996, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Bilal" },
                    { 2, 26, 72202, 346, new DateTime(1996, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Mansoor" },
                    { 3, 24, 83303, 307, new DateTime(1998, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Ahsan" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "TicketNo", "Departure", "Destination", "Name", "Source", "TrainNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), "Karachi", "Bilal", "Islamabad", 2 },
                    { 2, new DateTime(2022, 8, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), "Karachi", "Ahsan", "Islamabad", 2 },
                    { 3, new DateTime(2022, 8, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), "Karachi", "Mansoor", "Islamabad", 2 }
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "SchduleId", "Arrival", "Departure", "Destination", "Journey", "Source", "TrainNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 9, 23, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), "Karachi", new TimeSpan(0, 12, 15, 0, 0), "Islamabad", 2 },
                    { 2, new DateTime(2022, 8, 10, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), "Multan", new TimeSpan(0, 8, 15, 0, 0), "Lahore", 1 },
                    { 3, new DateTime(2022, 8, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "Islamabad", new TimeSpan(0, 2, 30, 0, 0), "Peshawar", 2 }
                });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "TrainNo", "Capacity", "SeatsAvailable", "SeatsBooked" },
                values: new object[,]
                {
                    { 1, 200, 197, 3 },
                    { 2, 100, 100, 0 },
                    { 3, 150, 150, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
