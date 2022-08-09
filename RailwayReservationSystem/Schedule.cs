using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Schedule
    {
        [Key]
        public int SchduleId { get; set; }
        public int TrainNo { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public TimeSpan Journey { get; set; }

        public Schedule()
        {

        }

        public Schedule(int trainNo, string source, string destination, DateTime departure, DateTime arrival)
        {
            this.TrainNo = trainNo;
            this.Source = source;
            this.Destination = destination;
            this.Departure = departure;
            this.Arrival = arrival;
            this.Journey = arrival - departure;
        }

        public void View(List<Schedule> Schedules)
        {
            Console.WriteLine("ScheduleID\tTrainNo\tFrom\t\tTo\t\t\tDeparture\t\tArrival\t\t\tHours");
            foreach (var schedule in Schedules)
            {
                Console.WriteLine("S-" + schedule.SchduleId + "\t\tT-" + schedule.TrainNo + "\t" + schedule.Source + "\t" + schedule.Destination + "\t\t" + schedule.Departure + "\t" + schedule.Arrival + "\t\t" +  schedule.Journey.Hours + ":" + schedule.Journey.Minutes);
            }
            
        }
    }
}
