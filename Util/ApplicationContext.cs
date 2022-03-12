using chemex.Models;
using Microsoft.EntityFrameworkCore;

namespace chemex.Util{ 
    public class ApplicationContext: DbContext{ 
        public DbSet<User> Users{ get; set; }

        public ApplicationContext() {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;password=rootroot;database=chemex;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}