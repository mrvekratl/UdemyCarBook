using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=UdemyCarBookDb;initial Catalog=UdemyCarBookDb;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reservation>()
               .HasOne(x => x.PickUpLocation)
               .WithMany(y => y.PickUpReservation)
               .HasForeignKey(z => z.PickUpLocationID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.DropOffLocation)
                .WithMany(y => y.DropOffReservation)
                .HasForeignKey(z => z.DropOffLocationID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            // BRAND DATA
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandID = 1, Name = "Volkswagen" },
                new Brand { BrandID = 2, Name = "BMW" },
                new Brand { BrandID = 3, Name = "Mercedes" },
                new Brand { BrandID = 4, Name = "Renault" },
                new Brand { BrandID = 5, Name = "Toyota" },
                new Brand { BrandID = 6, Name = "Hyundai" }
            );

            // LOCATION DATA
            modelBuilder.Entity<Location>().HasData(
                new Location { LocationID = 1, Name = "İstanbul - Sabiha Gökçen Havalimanı" },
                new Location { LocationID = 2, Name = "İstanbul - İstanbul Havalimanı" },
                new Location { LocationID = 3, Name = "Ankara - Esenboğa Havalimanı" },
                new Location { LocationID = 4, Name = "İzmir - Adnan Menderes Havalimanı" },
                new Location { LocationID = 5, Name = "Antalya - Antalya Havalimanı" },
                new Location { LocationID = 6, Name = "Bursa - Yenişehir Havalimanı" },
                new Location { LocationID = 7, Name = "Adana - Şakirpaşa Havalimanı" },
                new Location { LocationID = 8, Name = "Trabzon - Trabzon Havalimanı" },
                new Location { LocationID = 9, Name = "Gaziantep - Oğuzeli Havalimanı" },
                new Location { LocationID = 10, Name = "Dalaman - Dalaman Havalimanı" }
            );

            // CAR DATA
            modelBuilder.Entity<Car>().HasData(
                new Car { CarID = 1, BrandID = 1, Model = "Polo", Km = 35000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Benzin", CoverImageUrl = "/images/polo.jpg" },
                new Car { CarID = 2, BrandID = 1, Model = "Golf", Km = 42000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Dizel", CoverImageUrl = "/images/golf.jpg" },
                new Car { CarID = 3, BrandID = 2, Model = "3 Serisi", Km = 28000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Benzin", CoverImageUrl = "/images/bmw3.jpg" },
                new Car { CarID = 4, BrandID = 2, Model = "5 Serisi", Km = 50000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Dizel", CoverImageUrl = "/images/bmw5.jpg" },
                new Car { CarID = 5, BrandID = 3, Model = "C200", Km = 31000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Benzin", CoverImageUrl = "/images/c200.jpg" },
                new Car { CarID = 6, BrandID = 3, Model = "E200", Km = 45000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Dizel", CoverImageUrl = "/images/e200.jpg" },
                new Car { CarID = 7, BrandID = 4, Model = "Clio", Km = 29000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Benzin", CoverImageUrl = "/images/clio.jpg" },
                new Car { CarID = 8, BrandID = 4, Model = "Megane", Km = 37000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Dizel", CoverImageUrl = "/images/megane.jpg" },
                new Car { CarID = 9, BrandID = 5, Model = "Corolla", Km = 33000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Benzin", CoverImageUrl = "/images/corolla.jpg" },
                new Car { CarID = 10, BrandID = 5, Model = "Yaris", Km = 25000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Hibrit", CoverImageUrl = "/images/yaris.jpg" },
                new Car { CarID = 11, BrandID = 6, Model = "i20", Km = 21000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Benzin", CoverImageUrl = "/images/i20.jpg" },
                new Car { CarID = 12, BrandID = 6, Model = "i30", Km = 34000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Dizel", CoverImageUrl = "/images/i30.jpg" },
                new Car { CarID = 13, BrandID = 1, Model = "Passat", Km = 48000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Dizel", CoverImageUrl = "/images/passat.jpg" },
                new Car { CarID = 14, BrandID = 2, Model = "X1", Km = 39000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Benzin", CoverImageUrl = "/images/x1.jpg" },
                new Car { CarID = 15, BrandID = 3, Model = "GLA 200", Km = 27000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Benzin", CoverImageUrl = "/images/gla200.jpg" },
                new Car { CarID = 16, BrandID = 4, Model = "Symbol", Km = 45000, Transmission = "Manuel", Seat = 5, Luggage = 2, Fuel = "Benzin", CoverImageUrl = "/images/symbol.jpg" },
                new Car { CarID = 17, BrandID = 5, Model = "Camry", Km = 37000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Hibrit", CoverImageUrl = "/images/camry.jpg" },
                new Car { CarID = 18, BrandID = 6, Model = "Tucson", Km = 32000, Transmission = "Otomatik", Seat = 5, Luggage = 4, Fuel = "Dizel", CoverImageUrl = "/images/tucson.jpg" },
                new Car { CarID = 19, BrandID = 1, Model = "T-Roc", Km = 22000, Transmission = "Otomatik", Seat = 5, Luggage = 3, Fuel = "Benzin", CoverImageUrl = "/images/troc.jpg" },
                new Car { CarID = 20, BrandID = 2, Model = "X5", Km = 55000, Transmission = "Otomatik", Seat = 5, Luggage = 5, Fuel = "Dizel", CoverImageUrl = "/images/x5.jpg" }
            );
        }


    }
}
