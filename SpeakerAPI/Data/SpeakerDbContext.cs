using SpeakerAPI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SpeakerDbContext : DbContext
{
    public DbSet<Speaker> Speakers { get; set; }

    public SpeakerDbContext(DbContextOptions<SpeakerDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Speaker>().HasData(
          new
          {
              SpeakerId = Guid.NewGuid().ToString(),
              FirstName = "Tom",
              LastName = "Day",
              Email = "TomDay@gmail.com",
              MobileNumber = "778-554-2322",
              AreaOfSpecialization = "Plumber",
              CityOfResidence = "Surrey",
              ProvinceOfResidence = "BC",
              Employer = "Super Plumber"
          }, new
          {
              SpeakerId = Guid.NewGuid().ToString(),
              FirstName = "John",
              LastName = "Fox",
              Email = "JohnFox@gmail.com",
              MobileNumber = "778-554-2888",
              AreaOfSpecialization = "Construction",
              CityOfResidence = "Surrey",
              ProvinceOfResidence = "BC",
              Employer = "JF Construction"
          }, new
          {
              SpeakerId = Guid.NewGuid().ToString(),
              FirstName = "Art",
              LastName = "Ash",
              Email = "ArtAsh@gmail.com",
              MobileNumber = "778-554-4444",
              AreaOfSpecialization = "Waitress",
              CityOfResidence = "Surrey",
              ProvinceOfResidence = "BC",
              Employer = "Cactus Club"
          }, new
          {
              SpeakerId = Guid.NewGuid().ToString(),
              FirstName = "Mia",
              LastName = "Hay",
              Email = "HiaMia@gmail.com",
              MobileNumber = "778-554-7777",
              AreaOfSpecialization = "Technician",
              CityOfResidence = "Surrey",
              ProvinceOfResidence = "BC",
              Employer = "Yessir"
          }
        );
    }
}
