using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Schedule
    {
        private static int id = 101;
        public int SchduleId { get; set; }
        public int TrainNo { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Departure { get; set; }
        public TimeOnly Arrival { get; set; }
        public TimeSpan Journey { get; set; }


        public Schedule(int trainNo, string source, string destination, DateOnly date, TimeOnly departure, TimeOnly arrival)
        {
            this.SchduleId = id++;
            this.TrainNo = trainNo;
            this.Source = source;
            this.Destination = destination;
            this.Date = date;
            this.Departure = departure;
            this.Arrival = arrival;
            this.Journey = arrival - departure;
        }

        public void View(List<Schedule> Schedules)
        {
            Console.WriteLine("ScheduleID\tTrainNo\tFrom\t\tTo\t\tDate\t\tDeparture\tArrival\t\tHours");
            foreach (var schedule in Schedules)
            {
                Console.WriteLine("S-" + schedule.SchduleId + "\t\tT-" + schedule.TrainNo + "\t" + schedule.Source + "\t" + schedule.Destination + "\t\t" + schedule.Date + "\t" + schedule.Departure + "\t" + schedule.Arrival + "\t\t" + schedule.Journey.Hours + ":" + schedule.Journey.Minutes);
            }
            
        }
    }
}
