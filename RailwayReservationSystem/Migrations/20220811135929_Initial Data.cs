using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailwayReservationSystem.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Age", "CNIC", "Contact", "DOB", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 26, "61101-5621752-1", "03365266336", new DateTime(1996, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Bilal" },
                    { 2, 26, "72202-7652181-3", "03075266797", new DateTime(1996, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Mansoor" },
                    { 3, 24, "83303-1435679-9", "0307-5266216", new DateTime(1998, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "Ahsan" }
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

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleId", "Arrival", "Departure", "Destination", "Journey", "Source", "TrainNo" },
                values: new object[] { 1, new DateTime(2022, 8, 9, 23, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 11, 30, 0, 0, DateTimeKind.Unspecified), "Karachi", new TimeSpan(0, 12, 15, 0, 0), "Islamabad", 2 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleId", "Arrival", "Departure", "Destination", "Journey", "Source", "TrainNo" },
                values: new object[] { 2, new DateTime(2022, 8, 10, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), "Multan", new TimeSpan(0, 8, 15, 0, 0), "Karachi", 1 });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleId", "Arrival", "Departure", "Destination", "Journey", "Source", "TrainNo" },
                values: new object[] { 3, new DateTime(2022, 8, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "Islamabad", new TimeSpan(0, 2, 30, 0, 0), "Peshawar", 3 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "TicketNo", "PassengerId", "ScheduleId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 3, 2 },
                    { 5, 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "TicketNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "TicketNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "TicketNo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "TicketNo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "TicketNo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "ScheduleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "ScheduleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "ScheduleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainNo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainNo",
                keyValue: 2);
        }
    }
}
