using Microsoft.EntityFrameworkCore;

namespace Chemex.Models.Db{ 
    public class UserContext: DbContext{ 
        public DbSet<User> Users{ get; set; }

        public UserContext(DbContextOptions<UserContext> options): base(options){ 
            Database.EnsureCreated();
        }
    }
}