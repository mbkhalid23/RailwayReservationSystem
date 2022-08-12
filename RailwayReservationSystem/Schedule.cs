using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public TimeSpan Journey { get; set; }

        //Navigation Entries
        [ForeignKey("Train")]
        public int? TrainNo { get; set; }
        public Train Train { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        
        public Schedule()
        {

        }

        public Schedule(string source, string destination, DateTime departure, DateTime arrival)
        {
            this.Source = source;
            this.Destination = destination;
            this.Departure = departure;
            this.Arrival = arrival;
            this.Journey = arrival - departure;
        }

        public void View(List<Schedule> Schedules)
        {
            Console.WriteLine("ScheduleID\tFrom\t\tTo\t\t\tDeparture\t\tArrival\t\t\tHours");
            foreach (var schedule in Schedules)
            {
                Console.WriteLine("S-" + schedule.ScheduleId + "\t\tT-" + schedule.Source + "\t" + schedule.Destination + "\t\t" + schedule.Departure + "\t" + schedule.Arrival + "\t\t" + schedule.Journey.Hours + ":" + schedule.Journey.Minutes);
            }

        }

        public void Viewdb()
        {
            Console.WriteLine($"S-ID: {this.ScheduleId}");
            Console.WriteLine($"From: {this.Source}");
            Console.WriteLine($"To: {this.Destination}");
            Console.WriteLine($"Departure: {this.Departure}");
            Console.WriteLine($"Arrival: {this.Arrival}");
            Console.WriteLine($"Journey(hrs): {this.Journey}y");
            Console.WriteLine($"TrainNo:{this.TrainNo}");
            Console.WriteLine(new String('-', 30));

        }
    }
}
