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
            //modelBuilder.Entity<Passenger>().HasData(
            //    new Passenger { PassengerId = 1, Name = "Bilal", CNIC = "61101-5621752-1", Gender = "M", DOB = new DateTime(1996, 07, 17), Age = 26, Contact = "03365266336" },
            //    new Passenger { PassengerId = 2, Name = "Mansoor", CNIC = "72202-7652181-3", Gender = "M", DOB = new DateTime(1996, 05, 16), Age = 26, Contact = "03075266797" },
            //    new Passenger { PassengerId = 3, Name = "Ahsan", CNIC = "83303-1435679-9", Gender = "M", DOB = new DateTime(1998, 08, 23), Age = 24, Contact = "03075266216" });

            //modelBuilder.Entity<Train>().HasData(
            //    new Train { TrainNo = 1, Capacity = 200, SeatsAvailable = 198, SeatsBooked = 2 },
            //    new Train { TrainNo = 2, Capacity = 100, SeatsAvailable = 97, SeatsBooked = 3 },
            //    new Train { TrainNo = 3, Capacity = 150, SeatsAvailable = 150, SeatsBooked = 0 });

            //modelBuilder.Entity<Schedule>().HasData(
            //    new Schedule { ScheduleId = 1, Source = "Islamabad", Destination = "Karachi", Departure = new DateTime(2022, 08, 09, 11, 30, 00), Arrival = new DateTime(2022, 08, 09, 23, 45, 00), Journey = new TimeSpan(12, 15, 00), TrainNo = 2 },
            //    new Schedule { ScheduleId = 2, Source = "Karachi", Destination = "Multan", Departure = new DateTime(2022, 08, 10, 08, 30, 00), Arrival = new DateTime(2022, 08, 10, 16, 45, 00), Journey = new TimeSpan(08, 15, 00), TrainNo = 1 },
            //    new Schedule { ScheduleId = 3, Source = "Peshawar", Destination = "Islamabad", Departure = new DateTime(2022, 08, 10, 11, 30, 00), Arrival = new DateTime(2022, 08, 09, 14, 00, 00), Journey = new TimeSpan(2, 30, 00), TrainNo = 3 });

            //modelBuilder.Entity<Reservation>().HasData(
            //    new Reservation { TicketNo = 1, ScheduleId = 1, PassengerId = 1 },
            //    new Reservation { TicketNo = 2, ScheduleId = 1, PassengerId = 2 },
            //    new Reservation { TicketNo = 3, ScheduleId = 1, PassengerId = 3 },
            //    new Reservation { TicketNo = 4, ScheduleId = 2, PassengerId = 3 },
            //    new Reservation { TicketNo = 5, ScheduleId = 2, PassengerId = 3 });

        }
    }
}
