using Microsoft.EntityFrameworkCore;
using MigraineBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog
{
    public class MigraineContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MigraineDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Personal Stories",
                    Description = "This is a place where you can share your own stories relating to your migraines. It would help users to keep content related to your migraines/headaches and how they impact your life."
                },

                new Category
                {
                    Id = 2,
                    Name = "Ask a Doctor",
                    Description = "If you have a medically sensitive question relating to your migraine/headache conditions or medication, write a post about it here! A vetted team of doctors will read them and give advice."
                },

                new Category
                {
                    Id = 3,
                    Name = "Tips & Tricks",
                    Description = "If you have any tips for other migraineurs concerning avoidance methods, triggers or over-the-counter relief techniques, post about it here!"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
