using RailwayReservationSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Reservation
    {
        [Key]
        public int TicketNo { get; set; }

        //Navigation Entries
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public void AddReservation(String name, string frm, string to, DateTime dep)
        {
            using var context = new ApplicationDbContext();

            var passenger = (from p in context.Passengers
                             where p.Name == name
                             select p).FirstOrDefault();

            passenger.View();


            var schedule = (from s in context.Schedule
                            where s.Source == frm && s.Destination == to && s.Departure.Date == dep.Date
                            select s).FirstOrDefault();

            schedule.View();


            var train = (from t in context.Trains
                         where t.TrainNo == schedule.TrainNo
                         select t).FirstOrDefault();

            train.View();

            var reservation = new Reservation
            {
                PassengerId = passenger.PassengerId,
                ScheduleId = schedule.ScheduleId
            };

            context.Reservations.Add(reservation);

            train.ReserveSeat();

            context.SaveChanges();
        }


        public void View()
        {
            Console.WriteLine("Ticket# R-" + this.TicketNo);
            Console.WriteLine("Train No: T-" + this.Schedule.TrainNo);
            Console.WriteLine("Name: " + this.Passenger.Name);
            Console.WriteLine("From: " + this.Schedule.Source);
            Console.WriteLine("To: " + this.Schedule.Destination);
            Console.WriteLine("Departure: " + this.Schedule.Departure);
        }

        
    }
}
