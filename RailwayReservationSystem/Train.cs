using RailwayReservationSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Train
    {
        [Key]
        public int TrainNo { get; set; }
        public int Capacity { get; set; }
        public int SeatsAvailable { get; set; }
        public int SeatsBooked { get; set; }

        //Navigation Entries
        public ICollection<Schedule> Schedule { get; set; }

        public Train()
        {

        }
        public Train(int capacity)
        {
            using var context = new ApplicationDbContext();

            Capacity = capacity;
            SeatsAvailable = capacity;
            SeatsBooked = 0;

            context.Trains.Add(this);

            context.SaveChanges();
        }

        public void View()
        {
            Console.WriteLine("Train No: T-" + this.TrainNo);
            Console.WriteLine("Seating Capacity: " + this.Capacity);
            Console.WriteLine("Seats Available: " + this.SeatsAvailable);
            Console.WriteLine("Seats Booked: " + this.SeatsBooked);
            Console.WriteLine(new String('-', 30));
        }
        public void ViewAll()
        {
            using var context = new ApplicationDbContext();

            var trains = from t in context.Trains
                         select t;

            foreach(var train in trains)
            {
                Console.WriteLine("Train No: T-" + train.TrainNo);
                Console.WriteLine("Seating Capacity: " + train.Capacity);
                Console.WriteLine("Seats Available: " + train.SeatsAvailable);
                Console.WriteLine("Seats Booked: " + train.SeatsBooked);
                Console.WriteLine(new String('-', 30));
            }
        }
        public void Update(int trainNo, int newcapacity)
        {
            using var context = new ApplicationDbContext();

            var train = (from t in context.Trains
                         where t.TrainNo == trainNo
                         select t).FirstOrDefault();

            if (train != null)
            {
                train.Capacity = newcapacity;
                train.SeatsAvailable = train.Capacity - train.SeatsBooked;
            }
            else
            {
                Console.WriteLine("Train does not exist");
                return;
            }

            context.SaveChanges();
        }
        public void Remove(int trainNo)
        {
            using var context = new ApplicationDbContext();

            var train = (from t in context.Trains
                         where t.TrainNo == trainNo
                         select t).FirstOrDefault();

            if (train != null)
            {
                context.Trains.Remove(train);
            }
            else
            {
                Console.WriteLine("Train does not exist");
                return;
            }

            context.SaveChanges();
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
