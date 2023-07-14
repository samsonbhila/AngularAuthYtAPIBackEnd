using AngularAuthYtAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularAuthYtAPI.Context
{
    public class FullstackDbContext : DbContext
    {
        public FullstackDbContext(DbContextOptions options) : base(options)
        {
        }
 
        public DbSet<NaturalGase> natural_gases { get; set; }
    }
}
