using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_darklook.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Posts> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Games" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Playstation" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Reviews" });

            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 1,
                Title = "The best online game is out now!",
                Content = " lorem very carrots, enhanced undergraduate developer, but they do occaecat time and vitality, such as labor and obesity. Who suspend basketball very pregnant .... " ,

            ImageUrl = "./img/blog/1.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 2,
                Title = "Top 5 best games in november",
                Content  =  " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed tempor and vitality, so that the labor and sorrow, some important things to do eiusmod. Ultrices gravida .... Who hung up the very hard work " ,

                ImageUrl = "./img/blog/2.jpg",
                CategoryId = 2
            });



            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 3,
                Title = "The best online game is out now!",
                Content  =  " To be honest, the main undergraduate developer, but they do occaecat time and vitality, such as labor and obesity. Who recommended that pregnant basketball ncididunt to work .... " ,

                ImageUrl = "./img/blog/3.jpg",
                CategoryId = 3
            });
        }
    }
}
