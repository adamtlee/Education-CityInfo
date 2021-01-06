using CityInfo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {
            // Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City()
                {
                    Id = 1,
                    Name = "Denver",
                    Description = "Denver, Colorado."
                },
                new City()
                {
                    Id = 2,
                    Name = "Arvada",
                    Description = "Arvada, Colorado."
                },
                new City()
                {
                    Id = 3,
                    Name = "Boulder",
                    Description = "Boulder, Colorado"
                },
                new City()
                {
                    Id = 4,
                    Name = "Estes Park",
                    Description = "Estes Park, Colorado"
                },
                new City()
                {
                    Id = 5,
                    Name = "Glenwood Springs",
                    Description = "Glenwood Springs, Colorado"
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Botanic Gardens",
                    Description = "Place that has wonderful Nature"
                },
                 new PointOfInterest()
                 {
                     Id = 2,
                     CityId = 1,
                     Name = "Museum of Nature and Science",
                     Description = "A place with historical artifacts"
                 },
                 new PointOfInterest()
                 {
                     Id = 3,
                     CityId = 2,
                     Name = "Olde Town",
                     Description = "Pretty much the downtown of Arvada"
                 },
                  new PointOfInterest()
                  {
                      Id = 4,
                      CityId = 3,
                      Name = "Olde Town",
                      Description = "Pretty much the downtown of Arvada"
                  },
                   new PointOfInterest()
                   {
                       Id = 5,
                       CityId = 4,
                       Name = "Stanley Hotel",
                       Description = "A Haunted Hotel In Estes"
                   },
                   new PointOfInterest()
                   {
                       Id = 6,
                       CityId = 5,
                       Name = "Hotel Colorado",
                       Description = "A Haunted Hotel in Glenwood"
                   },
                    new PointOfInterest()
                    {
                        Id = 7,
                        CityId = 5,
                        Name = "Iron Mountain Hotsprings",
                        Description = "Relaxing hot springs in Glenwood"
                    });
            base.OnModelCreating(modelBuilder);
        }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
