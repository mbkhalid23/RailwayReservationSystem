﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RailwayReservationSystem.Data;

#nullable disable

namespace RailwayReservationSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220811135812_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RailwayReservationSystem.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassengerId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("RailwayReservationSystem.Reservation", b =>
                {
                    b.Property<int>("TicketNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketNo"), 1L, 1);

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("TicketNo");

                    b.HasIndex("PassengerId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("RailwayReservationSystem.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Journey")
                        .HasColumnType("time");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainNo")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("TrainNo");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("RailwayReservationSystem.Train", b =>
                {
                    b.Property<int>("TrainNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainNo"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("SeatsAvailable")
                        .HasColumnType("int");

                    b.Property<int>("SeatsBooked")
                        .HasColumnType("int");

                    b.HasKey("TrainNo");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("RailwayReservationSystem.Reservation", b =>
                {
                    b.HasOne("RailwayReservationSystem.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RailwayReservationSystem.Schedule", "Schedule")
                        .WithMany("Reservations")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("RailwayReservationSystem.Schedule", b =>
                {
                    b.HasOne("RailwayReservationSystem.Train", "Train")
                        .WithMany("Schedule")
                        .HasForeignKey("TrainNo");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("RailwayReservationSystem.Passenger", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RailwayReservationSystem.Schedule", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RailwayReservationSystem.Train", b =>
                {
                    b.Navigation("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
