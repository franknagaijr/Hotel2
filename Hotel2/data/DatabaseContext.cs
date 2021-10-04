using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel2.data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                { 
                    Id=1, 
                    Name="United States", 
                    ShortName = "USA"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "Spain",
                     ShortName = "ESP"
                 },
                  new Country
                  {
                      Id = 3,
                      Name = "Switzerland",
                      ShortName = "CH"
                  }
                );
            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name= "USA No 1",
                   CountryId=1,
                   Address = "Cherry Moon",
                   Rating = 1
               },
                new Hotel
                {
                    Id = 2,
                    Name = "ESP No 1",
                    CountryId = 2,
                    Address = "Cherry Luna",
                    Rating = 1
                },
                 new Hotel
                 {
                     Id = 3,
                     Name = "CH No 1",
                     CountryId = 3,
                     Address = "Cherry Mond",
                     Rating = 1
                 }
               );
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
