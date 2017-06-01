using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace davidharveysblog.Services
{
    public class DavidHarveysBlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Local
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SAG74I3\DEVELOPMENT;Database=davidharveysblog;Trusted_Connection=True;");
        }
    }
}
