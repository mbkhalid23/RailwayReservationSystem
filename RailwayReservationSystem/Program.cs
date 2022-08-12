using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayReservationSystem.Data;


namespace RailwayReservationSystem
{
    class Program
    {
        static void MakeReservation()
        {
            using var context = new ApplicationDbContext();

            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("From: ");
            string frm = Console.ReadLine();
            Console.WriteLine("To: ");
            string to = Console.ReadLine();
            Console.WriteLine("Departure: yyyy-mm-dd");
            DateTime dep = DateTime.Parse(Console.ReadLine());

            var passenger = (from p in context.Passengers
                       where p.Name == name
                       select p).FirstOrDefault();

            passenger.View();

            var schedule = (from s in context.Schedule
                       where s.Source == frm && s.Destination == to && s.Departure.Date == dep.Date
                       select s).FirstOrDefault();

            
                schedule.Viewdb();
                

            var train = (from t in context.Trains
                       where t.TrainNo == schedule.TrainNo
                       select t).FirstOrDefault();

            train.View();

            var reservation = new Reservation
            {
                PassengerId = passenger.PassengerId,
                ScheduleId = schedule.ScheduleId
            };

            context.Reservations.Add(reservation);

            train.ReserveSeat();

            context.SaveChanges();



        }


        static void Main()
        {
            Program.MakeReservation();

            //using (var context = new ApplicationDbContext())
            //{
                //var passenger = new Passenger()
                //{
                //    Name = "Bilal Khalid",
                //    CNIC = "61101-5616272-1",
                //    Gender = "M",
                //    DOB = new DateTime(1996, 07, 17),
                //    Age = 26,
                //    Contact = "+92-307-5266797"
                //};

                //context.Passengers.Add(passenger);

                //context.SaveChanges();

            //    var pas = (from passenger in context.Passengers
            //                    where passenger.Name == "Ahsan"
            //                    select new Passenger { PassengerId =  passenger.PassengerId }).FirstOrDefault();
                
            //    pas.View();

            //    var dep = new DateTime(2022, 08, 09, 11, 30, 00);

            //    var sch = (from schedule in context.Schedule
            //              where schedule.Source == "Islamabad" && schedule.Destination == "Karachi" && schedule.Departure.Date == dep.Date
            //              select new Schedule { ScheduleId = schedule.ScheduleId, TrainNo = schedule.TrainNo }).FirstOrDefault();

            //    var tra = (from train in context.Trains
            //              where train.TrainNo == sch.TrainNo
            //              select train).FirstOrDefault();

            //    sch.Viewdb();

            //    tra.View();

            //    //var res = new Reservation
            //    //{
            //    //    PassengerId = pas.PassengerId,
            //    //    ScheduleId = sch.ScheduleId,
            //    //};

            //    //context.Reservations.Add(res);

            //    tra.ReserveSeat();

            //    context.SaveChanges();
            //}

            

            //var Passengers = new List<Passenger> { };
            //var Trains = new List<Train> { };
            //var Schedules = new List<Schedule> { };
            //var Reservations = new List<Reservation> { };

            //var date = new DateTime(2001, 05, 21);
            //var date1 = new DateTime(1996, 07, 17);
            //var date2 = new DateOnly(2022, 07, 30);


            //var dep = new DateTime(2022, 07, 30, 22, 30, 00);
            //var arr = new DateTime(2022, 07, 31, 12, 45, 00);

            //Passengers.Add(new Passenger(61101, "Bilal", "Male", date1, 0336));
            //Passengers.Add(new Passenger(72202, "Daniyal", "Male", date, 0344));

            ////passengers.Add(passenger1);
            ////passengers.Add(passenger2);

            ////Console.WriteLine("PASSENGER");
            ////passenger.View();
            ////Console.WriteLine("");

            //Trains.Add(new Train(200));
            //Trains.Add(new Train(100));
            ////Console.WriteLine("TRAIN");
            ////train.View();
            ////Console.WriteLine("");

            //Schedules.Add(new Schedule(Trains[0].TrainNo, "Islamabad", "Karachi", dep, arr));
            //Schedules.Add(new Schedule(Trains[1].TrainNo, "Faisalabad", "Multan", dep, arr));
            ////Console.WriteLine("SCHEDULE");
            ////schedule.View();
            ////Console.WriteLine("");

            //Reservations.Add(new Reservation(Trains[0], Schedules[0], Passengers[0]));
            //Reservations.Add(new Reservation(Trains[0], Schedules[0], Passengers[1]));
            //Reservations.Add(new Reservation(Trains[1], Schedules[0], Passengers[0]));
            //Reservations.Add(new Reservation(Trains[1], Schedules[0], Passengers[1]));
            ////Console.WriteLine("RESERVATION");
            ////reservation.View();
            ////Console.WriteLine("");

            ////Console.WriteLine("Seats Left: " + train.SeatsAvailable);




            //foreach (var passenger in Passengers)
            //{
            //    Console.WriteLine("PASSENGERS");
            //    passenger.View();
            //    Console.WriteLine();
            //}

            //Console.WriteLine("TRAINS");
            //Trains[0].ViewAll(Trains);
            //Console.WriteLine();


            //Console.WriteLine("SCHEDULE");
            //Schedules[0].View(Schedules);
            //Console.WriteLine();

            //foreach (var reservation in Reservations)
            //{
            //    Console.WriteLine("RESERVATIONS");
            //    reservation.View();
            //    Console.WriteLine();
            //}
        }
    }
}
