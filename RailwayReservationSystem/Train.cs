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

        public void AddNew(int capacity)
        {
            using var context = new ApplicationDbContext();

            var NewTrain = new Train
            {
                Capacity = capacity,
                SeatsAvailable = capacity,
                SeatsBooked = 0
            };

            context.Trains.Add(NewTrain);

            context.SaveChanges();
        }
        public void View()
        {
            Console.WriteLine("Train No: T-" + this.TrainNo);
            Console.WriteLine("Seating Capacity: " + this.Capacity);
            Console.WriteLine("Seats Booked: " + this.SeatsBooked);
            Console.WriteLine("Seats Available: " + this.SeatsAvailable);
            Console.WriteLine(new String('-', 30));
        }
        public void Update(int trainNo)
        {
            using var context = new ApplicationDbContext();

            var train = (from t in context.Trains
                         where t.TrainNo == trainNo
                         select t).FirstOrDefault();

            Console.WriteLine("Enter Updated Train Capacity: ");

            train.Capacity = int.Parse(Console.ReadLine());
            train.SeatsAvailable = train.Capacity - train.SeatsBooked;

            context.SaveChanges();
        }
        public void Remove(int trainNo)
        {
            using var context = new ApplicationDbContext();

            var train = (from t in context.Trains
                         where t.TrainNo == trainNo
                         select t).FirstOrDefault();

            context.Trains.Remove(train);

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
