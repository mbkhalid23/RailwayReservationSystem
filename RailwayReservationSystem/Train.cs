using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Train
    {
        private static int id = 101;
        public int TrainNo { get; set; }
        public int Capacity { get; set; }
        public int SeatsBooked { get; set; }
        public int SeatsAvailable { get; set; }

        public Train(int capacity)
        {
            this.TrainNo = id++;
            this.Capacity = capacity;
            this.SeatsAvailable = capacity;
            this.SeatsBooked = 0;
        }

        public void View()
        {
            Console.WriteLine("Train No: T-"+this.TrainNo);
            Console.WriteLine("Seating Capacity: "+this.Capacity);
            Console.WriteLine("Seats Booked: " + this.SeatsBooked);
            Console.WriteLine("Seats Available: " + this.SeatsAvailable);
        }

        public void ReserveSeat ()
        {
            if (this.SeatsAvailable > 0) 
            {
                this.SeatsAvailable--;
                this.SeatsBooked++;
            }
            else
            {
                Console.WriteLine("Not enough seats available!");
            }
        }

        public void VacateSeat()
        {
            if (this.SeatsBooked > 0)
            {
                this.SeatsAvailable++;
                this.SeatsBooked--;
            }
            else
            {
                Console.WriteLine("No Seats Booked!");
            }
        }
    }
}
