using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Datalayer.Data_table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zones>()
                .HasKey(o => new { o.Lpid, o.Zonename });
        }

    }
}
