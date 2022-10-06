using Bogus_MVC_.Models;
using Microsoft.EntityFrameworkCore;

namespace Bogus_MVC_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User_> Users { get; set; }
    }
}
