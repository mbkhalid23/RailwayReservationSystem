using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    class Program
    {
        static void Main()
        {
            var Passengers = new List<Passenger> { };
            var Trains = new List<Train> { };
            var Schedules = new List<Schedule> { };
            var Reservations = new List<Reservation> { };

            var date = new DateOnly(2001, 05, 21);
            var date1 = new DateOnly(1996, 07, 17);
            var date2 = new DateOnly(2022, 07, 30);


            var dep = new TimeOnly(11, 30);
            var arr = new TimeOnly(18, 15);

            Passengers.Add(new Passenger(61101, "Bilal", "Male", date1, 0336));
            Passengers.Add(new Passenger(72202, "Daniyal", "Male", date, 0344));

            //passengers.Add(passenger1);
            //passengers.Add(passenger2);

            //Console.WriteLine("PASSENGER");
            //passenger.View();
            //Console.WriteLine("");

            Trains.Add(new Train(213, 200));
            //Console.WriteLine("TRAIN");
            //train.View();
            //Console.WriteLine("");

            Schedules.Add(new Schedule(501, "Islamabad", "Karachi", date2, dep, arr));
            //Console.WriteLine("SCHEDULE");
            //schedule.View();
            //Console.WriteLine("");

            Reservations.Add(new Reservation(Trains[0], Schedules[0], Passengers[0]));
            Reservations.Add(new Reservation(Trains[0], Schedules[0], Passengers[1]));
            //Console.WriteLine("RESERVATION");
            //reservation.View();
            //Console.WriteLine("");

            //Console.WriteLine("Seats Left: " + train.SeatsAvailable);




            foreach (var passenger in Passengers)
            {
                Console.WriteLine("PASSENGERS");
                passenger.View();
                Console.WriteLine();
            }

            foreach (var train in Trains)
            {
                Console.WriteLine("TRAINS");
                train.View();
                Console.WriteLine();
            }

            foreach (var schedule in Schedules)
            {
                Console.WriteLine("SCHEDULE");
                schedule.View();
                Console.WriteLine();
            }

            foreach (var reservation in Reservations)
            {
                Console.WriteLine("RESERVATIONS");
                reservation.View();
                Console.WriteLine();
            }
        }
    }
}
