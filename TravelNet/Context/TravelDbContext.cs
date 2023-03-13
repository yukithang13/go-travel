using Microsoft.EntityFrameworkCore;
using TravelNet.Models;

namespace TravelNet.Context
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
    }
}

