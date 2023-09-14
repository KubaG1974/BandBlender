using BandBlender.Models;
using Microsoft.EntityFrameworkCore;

namespace BandBlender.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }
        public DbSet<Band>? Bands { get; set; }
        public DbSet<Musician>? Musicians { get; set; }
        public DbSet<Genre>? Genres { get; set; }
    }
}