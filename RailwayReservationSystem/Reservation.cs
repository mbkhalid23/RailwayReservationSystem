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

        public Reservation()
        {

        }

        public Reservation(Train train, Schedule schedule, Passenger passenger)
        {
            //this.TrainNo = train.TrainNo;
            //this.Name = passenger.Name;
            //this.Source = schedule.Source;
            //this.Destination = schedule.Destination;
            //this.Departure = schedule.Departure;
            //train.ReserveSeat();
        }

        public void View()
        {
            //Console.WriteLine("Ticket# R-" + this.TicketNo);
            //Console.WriteLine("Train No: T-" + this.TrainNo);
            //Console.WriteLine("Name: " + this.Name);
            //Console.WriteLine("From: " + this.Source);
            //Console.WriteLine("To: " + this.Destination);
            //Console.WriteLine("Departure: " + this.Departure);
        }
        
    }
}
