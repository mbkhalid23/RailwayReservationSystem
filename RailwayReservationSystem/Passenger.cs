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
        public int CNIC { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateOnly DOB { get; set; }
        public int Age { get; set; }
        public int Contact { get; set; }

        public Passenger()
        {
        }

        public Passenger(int CNIC, string name, string gender, DateOnly dob, int contact)
        {
            this.CNIC = CNIC;
            this.Name = name;
            this.Gender = gender;
            this.DOB = dob;
            this.Age = (DateOnly.FromDateTime(DateTime.Today).DayNumber - dob.DayNumber)/365;
            this.Contact = contact;
        }

        public void View()
        {
            Console.WriteLine($"ID: {this.PassengerId}");
            Console.WriteLine($"CNIC: {this.CNIC}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Gender: {this.Gender}");
            Console.WriteLine($"DOB: {this.DOB}");
            Console.WriteLine($"Age: {this.Age}y");
            Console.WriteLine($"Contact: {this.Contact}");
        }
    }
}
