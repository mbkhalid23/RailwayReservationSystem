﻿using System;
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

        public Passenger(string name, string CNIC, string gender, DateTime dob, string contact)
        {
            this.Name = name;
            this.CNIC = CNIC;
            this.Gender = gender;
            this.DOB = dob;
            this.Age = (DateTime.Now - this.DOB).Days/365;
            this.Contact = contact;
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
    }
}
