using MagivVilla_VillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagivVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "The best of the best villa.",
                    ImageUrl = "https://dotnetmasteryimages.blog.core.windows.net/bluevillaimages/villa1.jpg",
                    Occupancy = 5,
                    Rate = 100,
                    Sqft = 150,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa2",
                    Details = "The best of the best villa.",
                    ImageUrl = "https://dotnetmasteryimages.blog.core.windows.net/bluevillaimages/villa2.jpg",
                    Occupancy = 6,
                    Rate = 200,
                    Sqft = 250,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Villa3",
                    Details = "The best of the best villa.",
                    ImageUrl = "https://dotnetmasteryimages.blog.core.windows.net/bluevillaimages/villa3.jpg",
                    Occupancy = 7,
                    Rate = 300,
                    Sqft = 350,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Royal Villa4",
                    Details = "The best of the best villa.",
                    ImageUrl = "https://dotnetmasteryimages.blog.core.windows.net/bluevillaimages/villa4.jpg",
                    Occupancy = 8,
                    Rate = 400,
                    Sqft = 450,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Royal Villa5",
                    Details = "The best of the best villa.",
                    ImageUrl = "https://dotnetmasteryimages.blog.core.windows.net/bluevillaimages/villa5.jpg",
                    Occupancy = 9,
                    Rate = 500,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
