using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger>().HasData(
                new Passenger { PassengerId = 1, CNIC = 61101, Name = "Bilal", Gender = "M", DOB = new DateOnly(1996, 07, 17), Age = 26, Contact = 0336 },
                new Passenger { PassengerId = 2, CNIC = 72202, Name = "Mansoor", Gender = "M", DOB = new DateOnly(1996, 05, 16), Age = 26, Contact = 0346 },
                new Passenger { PassengerId = 3, CNIC = 83303, Name = "Ahsan", Gender = "M", DOB = new DateOnly(1998, 08, 23), Age = 24, Contact = 0307 });

            modelBuilder.Entity<Train>().HasData(
                new Train { TrainNo = 1, Capacity = 200, SeatsAvailable = 197, SeatsBooked = 3 },
                new Train { TrainNo = 2, Capacity = 100, SeatsAvailable = 100, SeatsBooked = 0 },
                new Train { TrainNo = 3, Capacity = 150, SeatsAvailable = 150, SeatsBooked = 0 });

            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { SchduleId = 1, TrainNo = 2, Source = "Islamabad", Destination = "Karachi", Date = new DateOnly(2022,08,10), Departure = new TimeOnly(11,30), Arrival = new TimeOnly(22,45), Journey = new TimeSpan(11,15,00)},
                new Schedule { SchduleId = 2, TrainNo = 1, Source = "Lahore", Destination = "Multan", Date = new DateOnly(2022, 08, 11), Departure = new TimeOnly(12, 30), Arrival = new TimeOnly(18, 45), Journey = new TimeSpan(06, 15, 00) },
                new Schedule { SchduleId = 3, TrainNo = 2, Source = "Peshawar", Destination = "Islamabad", Date = new DateOnly(2022, 08, 11), Departure = new TimeOnly(14, 00), Arrival = new TimeOnly(15, 30), Journey = new TimeSpan(3, 30, 00) });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { TicketNo = 1, TrainNo = 2, Name = "Bilal", Source = "Islamabad", Destination = "Karachi", Departure = new DateTime(2022, 08, 10, 11, 30, 00) },
                new Reservation { TicketNo = 1, TrainNo = 2, Name = "Ahsan", Source = "Islamabad", Destination = "Karachi", Departure = new DateTime(2022, 08, 10, 11, 30, 00) },
                new Reservation { TicketNo = 1, TrainNo = 2, Name = "Mansoor", Source = "Islamabad", Destination = "Karachi", Departure = new DateTime(2022, 08, 10, 11, 30, 00) });

        }
    }
}
