using Microsoft.EntityFrameworkCore;
using TravelNet.Models;

namespace TravelNet.Context
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}

