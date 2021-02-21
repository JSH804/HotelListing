using Microsoft.EntityFrameworkCore;


namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States of America",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Mexico",
                    ShortName = "MX"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Holiday Inn",
                    Address = "Texas",
                    CountryId = 2,
                    Rating = 3.8
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Gran Hotel Ciudad De Mexico",
                    Address = "Mexico City",
                    CountryId = 3,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Rockhouse Hotel",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.6
                }
                );
        }
    }
}