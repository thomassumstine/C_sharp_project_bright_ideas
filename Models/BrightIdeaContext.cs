using Microsoft.EntityFrameworkCore;

namespace BrightIdeas.Models
{
    public class BrightIdeasContext : DbContext
    {
        public BrightIdeasContext(DbContextOptions options) : base(options) { }
        // DBSet prop name will be used as table names in DB
        public DbSet<BrightIdea> BrightIdea { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}