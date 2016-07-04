using Altkom.Bicycle.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.DAL
{
    public class BicycleContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }

        public DbSet<Bike> Bikes { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Rental> Rentals { get; set; }


        public BicycleContext()
            : base("Bicycle")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Person>().ToTable("Persons");

            modelBuilder.Entity<Person>()
                .Ignore(p => p.EyeColor);

        }

    }
}
