using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6BSINQC;Database=RRSDB;Trusted_Connection=True;");
        }

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
 