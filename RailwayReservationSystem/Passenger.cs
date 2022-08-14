using RailwayReservationSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }

        //Navigation Entries
        public ICollection<Reservation> Reservations { get; set; }

        public Passenger()
        {
        }
        public Passenger(string name, string cnic, string gender, DateTime dob, string contact)
        {
            using var context = new ApplicationDbContext();

            this.Name = name;
            this.CNIC = cnic;
            this.Gender = gender;
            this.DOB = dob;
            this.Age = (DateTime.Now - this.DOB).Days / 365;
            this.Contact = contact;

            context.Passengers.Add(this);

            context.SaveChanges();
        }

        public void View()
        {
            Console.WriteLine($"P-ID: {this.PassengerId}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"CNIC: {this.CNIC}");
            Console.WriteLine($"Gender: {this.Gender}");
            Console.WriteLine($"DOB: {this.DOB.ToShortDateString()}");
            Console.WriteLine($"Age: {this.Age}y");
            Console.WriteLine($"Contact: {this.Contact}");
            Console.WriteLine(new String('-', 30));
        }
        public void ViewAll()
        {
            using var context = new ApplicationDbContext();

            var passengers = from p in context.Passengers
                         select p;

            foreach (var passenger in passengers)
            {
                Console.WriteLine($"P-ID: {passenger.PassengerId}");
                Console.WriteLine($"Name: {passenger.Name}");
                Console.WriteLine($"CNIC: {passenger.CNIC}");
                Console.WriteLine($"Gender: {passenger.Gender}");
                Console.WriteLine($"DOB: {passenger.DOB.ToShortDateString()}");
                Console.WriteLine($"Age: {passenger.Age}y");
                Console.WriteLine($"Contact: {passenger.Contact}");
                Console.WriteLine(new String('-', 30));
            }
        }
        public void Update(string cnic, string newname, string newgender, DateTime newdob, string newcontact)
        {
            using var context = new ApplicationDbContext();

            var passenger = (from p in context.Passengers
                             where p.CNIC == cnic
                             select p).FirstOrDefault();


            if (passenger != null)
            {
                if (newname != null)
                {
                    passenger.Name = newname;
                }
                if (newgender != "")
                {
                    passenger.Gender = newgender;
                }
                if (newdob != DateTime.MinValue)
                {
                    passenger.DOB = newdob;
                }
                if (newcontact != "")
                {
                    passenger.Contact = newcontact;
                }
            }
            else
            {
                Console.WriteLine("Passenger does not exist");
                return;
            }

            context.SaveChanges();

        }
        public void Remove(string cnic)
        {
            using var context = new ApplicationDbContext();

            var passenger = (from p in context.Passengers
                             where p.CNIC == cnic
                             select p).FirstOrDefault();

            if (passenger != null)
            {
                context.Passengers.Remove(passenger);
            }
            else
            {
                Console.WriteLine("Passenger does not exist");
            }

            context.SaveChanges();
        }
    }
}
