using Microsoft.EntityFrameworkCore;

namespace DatingApi.Models
{
    public class DatingDbContext : DbContext
    {
        public DatingDbContext(DbContextOptions<DatingDbContext> options) : base (options)
        {
            
        }

        public DbSet<Value> Values {get; set;}

        public DbSet<User> Users {get; set;}

        public DbSet<Photo> Photos { get; set; }
    }
}