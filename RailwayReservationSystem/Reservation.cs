﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Reservation
    {
        public int TicketNo { get; set; }
        public int TrainNo { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }

        public Reservation(Train train, Schedule schedule, Passenger passenger)
        {
            this.TicketNo = -1;
            this.TrainNo = train.TrainNo;
            this.Name = passenger.Name;
            this.Source = schedule.Source;
            this.Destination = schedule.Destination;
            this.Departure = schedule.Date.ToDateTime(schedule.Departure);
            train.ReserveSeat();
        }

        public void View()
        {
            Console.WriteLine("Ticket No.: "+this.TicketNo);
            Console.WriteLine("Train No.: " + this.TrainNo);
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("From : " + this.Source);
            Console.WriteLine("To : " + this.Destination);
            Console.WriteLine("Departure : " + this.Departure);
        }

        
    }
}