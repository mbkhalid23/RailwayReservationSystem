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
                
        public void View()
        {
            Console.WriteLine($"S-ID: {this.ScheduleId}");
            Console.WriteLine($"From: {this.Source}");
            Console.WriteLine($"To: {this.Destination}");
            Console.WriteLine($"Departure: {this.Departure}");
            Console.WriteLine($"Arrival: {this.Arrival}");
            Console.WriteLine($"Journey(hrs): {this.Journey}");
            Console.WriteLine($"TrainNo:{this.TrainNo}");
            Console.WriteLine(new String('-', 30));

        }
    }
}
