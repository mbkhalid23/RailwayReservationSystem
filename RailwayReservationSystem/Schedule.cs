using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Schedule
    {
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
            this.TrainNo = trainNo;
            this.Source = source;
            this.Destination = destination;
            this.Date = date;
            this.Departure = departure;
            this.Arrival = arrival;
            this.Journey = arrival - departure;
        }

        public void View()
        {
            Console.WriteLine("TrainNo\tFrom\t\tTo\t\tDate\t\tDeparture\tArrival\t\tHours");
            Console.WriteLine(this.TrainNo+"\t"+this.Source+"\t"+this.Destination+"\t\t"+this.Date+"\t"+Departure+"\t"+Arrival+"\t\t"+this.Journey.Hours+":"+this.Journey.Minutes);
        }
    }
}
