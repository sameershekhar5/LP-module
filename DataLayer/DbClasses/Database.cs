using DataLayer.Data_table;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Datalayer.DbClasses
{
    public class Database:IdentityDbContext<LpDetails>
    {
        public Database(DbContextOptions<Database> option) : base(option)
        {
        }
        public DbSet<States> States { get; set; }
        public DbSet<Zones> Zones { get; set; }
        public DbSet<Pincodes> Pincodes { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Rates> Lprates { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zones>()
                .HasKey(o => new { o.Lpid, o.Name });
        }
    }
}
