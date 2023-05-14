using ED9ACS_HFT_2022232_Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ED9ACS_HFT_2022232_Data
{
    //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Mored\Documents\GitHub\ED9ACS_HFT_2022232\ED9ACS_HFT_2022232 Data\Database1.mdf";Integrated Security=True
    public class TalkWithYourFavoriteArtistDbContext : DbContext
    {
        public TalkWithYourFavoriteArtistDbContext()
        {

            this.Database.EnsureCreated();
        }

        public TalkWithYourFavoriteArtistDbContext(DbContextOptions<TalkWithYourFavoriteArtistDbContext> options) : base(options) { }
        public virtual DbSet<Fans> Fans { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<ReservationsServices> ConnectorTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                    UseLazyLoadingProxies().
                    UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security = True;MultipleActiveResultSets = True;MultipleActiveResultSets=True");
                
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Services service1 = new Services() { Id = 1, Name = "Video talk ", Price = 500, Rating = 8 };
            Services service2 = new Services() { Id = 2, Name = "Phone call ", Price = 250, Rating = 5 };
            Services service3 = new Services() { Id = 3, Name = "Book for an event ", Price = 5000, Rating = 10 };
            Services service4 = new Services() { Id = 4, Name = "Video Shout-out", Price = 200, Rating = 10 };
            Services service5 = new Services() { Id = 5, Name = "Meet your artist ", Price = 1000, Rating = 9 };
            Services service6 = new Services() { Id = 6, Name = "Audio shout-out", Price = 100, Rating = 4 };

            Artists artist1 = new Artists() { Id = 1, Name = "Stormy", Category = "Singer", Duration = 1, Price = 2500 };
            Artists artist2 = new Artists() { Id = 2, Name = "Rachid El Wali", Category = "Actor", Duration = 2, Price = 10000 };
            Artists artist3 = new Artists() { Id = 3, Name = "Redouane", Category = "Singer", Duration = 1, Price = 20000 };
            Artists artist4 = new Artists() { Id = 4, Name = "Don big", Category = "Singer", Duration = 3, Price = 10000 };
            Artists artist5 = new Artists() { Id = 5, Name = "Ahmed Cherkaoui", Category = "Painter", Duration = 1, Price = 20000 };
            Artists artist6 = new Artists() { Id = 6, Name = "Tahar Ben Jelloun", Category = "Writer", Duration = 1, Price = 30000 };

        }

        }
}
