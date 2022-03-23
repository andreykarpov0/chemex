using System;
using chemex.Models;
using Microsoft.EntityFrameworkCore;

namespace chemex.Util{ 
    public class ApplicationContext: DbContext{ 
        public DbSet<User> Users{ get; set; }
        public DbSet<Project> Projects{ get; set; }

        public ApplicationContext() {
            Database.EnsureCreated();
        }

        public bool Recreate(){
            bool succes;
            succes = Database.EnsureDeleted();
            succes = Database.EnsureCreated();
            return succes;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=localhost;user=root;password=rootroot;database=chemex;");
            optionsBuilder.UseMySQL("server=localhost;user=root;password=root;database=chemex;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User user1 = new User() { Id = 1, Login = "Admin", Email = "test@email.ru", Password = "12345qwert"};

            modelBuilder.Entity<User>().HasData(user1);

            Project pr1 = new Project() { Id = 1, 
            Name = "Проект 1", 
            CreationTime = DateTime.Now, 
            LastModifiedTime = DateTime.Now.AddDays(1), 
            UserId = user1.Id};

            modelBuilder.Entity<Project>().HasData(pr1);
        }
    }
}