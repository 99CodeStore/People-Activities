using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<PeopleActivity> PeopleActivities { get; set; }
    }
}