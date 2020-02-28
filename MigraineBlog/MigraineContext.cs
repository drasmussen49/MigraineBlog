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

            modelBuilder.Entity<Post>().HasData(
             new Post
             {
                 Id = 1,
                 Title = "Day Over",
                 Body = "I had a migraine over the weekend, and it totally ended my day. I had to close all the blinds in the house, sit in my bed with no sounds around and lie there. Nothing's worse than having a migraine on your day off and you can't even enjoy it...",
                 Author = "Dan",
                 CategoryId = 1
             },
            new Post
            {
                Id = 2,
                Title = "Unofficial Diagnosis",
                Body = "Hi. I have been suffering from what I THOUGHT were just regular old headaches, until I met someone who suffers from chronic migraines. Only then did I realize what I may be suffering from are actually migraines! Unfortunately, without having health insurance right now, I cannot afford the pricey trip to a doctor for an official diagnosis. I have been taking the advice of my migraine-having friends on how to identify my triggers and the best at-home solutions. It's not ideal, but it's the best I can do for now! Hang in there, everyone!  ",
                Author = "Rhianna",
                CategoryId = 1
            },
            new Post
            {
                Id = 3,
                Title = "Is This Okay?",
                Body = "I have taken four ibuprofen which are all 400mg each. Can I take more? Please? My migraine will not cease. SOS.",
                Author = "Joan",
                CategoryId = 2
            },
            new Post
            {
                Id = 4,
                Title = "Are Migraines Genetic?",
                Body = "I am a 30 year old female, and I received my official diagnosis for migraines 5 years ago. My husband and I would like to have children, but I am worried I will pass this cursed gene onto my kids. Should I be worried?",
                Author = "Rebecca",
                CategoryId = 2
            },
            new Post
            {
                Id = 5,
                Title = "When In Doubt, Sleep It Out!",
                Body = "I find that the best way to kill a migraine (or at least avoid the suffering!) is by... simply taking a nice long nap in a dark quiet place. Works like a charm!",
                Author = "Jefferson",
                CategoryId = 3
            },
            new Post
            {
                Id = 6,
                Title = "Everyday Helpful Tips",
                Body = "Make sure to always get enough sleep, at least 8 hours per night. Drink enough water! Avoid loud sounds. Stay off screens for extended periods of time. If you start to feel the ol' familiar ache behind your eyes, try a temperature sleeping-mask! You can heat them up in the microwave OR stick them in the freezer and rest them over your eyes. Hope these help!",
                Author = "Coral",
                CategoryId = 3
            });

            modelBuilder.Entity<Tag>().HasData(
            new Tag
            {
                Id = 1,
                Name = "#BadDay",
            },

            new Tag
            {
                Id = 2,
                Name = "#SOS",
            },

            new Tag
            {
                Id = 3,
                Name = "#Relief",
            },

            new Tag
            {
                Id = 4,
                Name = "#Triggers",
            },

            new Tag
            {
                Id = 5,
                Name = "#Advice",
            });

            modelBuilder.Entity<PostTag>().HasData(
            new PostTag
            {
                Id = 1,
                PostId = 1,
                TagId = 2,
            },

            new PostTag
            {
                Id = 2,
                PostId = 1,
                TagId = 4,
            },
            new PostTag
            {
                Id = 3,
                PostId = 2,
                TagId = 5,
            },
            new PostTag
            {
                Id = 4,
                PostId = 4,
                TagId = 2,
            },
            new PostTag
            {
                Id = 5,
                PostId = 4,
                TagId = 5,
            },
            new PostTag
            {
                Id = 6,
                PostId = 3,
                TagId = 2,
            },
            new PostTag
            {
                Id = 7,
                PostId = 3,
                TagId = 1,
            },
            new PostTag
            {
                Id = 8,
                PostId = 5,
                TagId = 4,
            },
            new PostTag
            {
                Id = 9,
                PostId = 5,
                TagId = 5,
            },
            new PostTag
            {
                Id = 10,
                PostId = 6,
                TagId = 5,
            },
            new PostTag
            {
                Id = 11,
                PostId = 6,
                TagId = 2,
            },
            new PostTag
            {
                Id = 12,
                PostId = 6,
                TagId = 3,
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
